using System;
using System.Collections;
using System.Collections.Generic;
using TheFirstPerson;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private bool b;
    private FPSController script;
    public GameObject reset;
    public GameObject boss;
    private int counter;
    private GameObject[] flies;

    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<FPSController>();
        boss = GameObject.FindGameObjectWithTag("Boss");
        flies = GameObject.FindGameObjectsWithTag("flying");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            
            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position + new Vector3(0,1,0), transform.TransformDirection(Vector3.forward), out hit,
                    4))
            {
                Debug.DrawRay(transform.position + new Vector3(0,1,0), transform.TransformDirection(Vector3.forward) * hit.distance,
                    Color.yellow);
                Debug.Log("Did Hit");
            }
            else
            {
                Debug.DrawRay(transform.position + new Vector3(0,1,0), transform.TransformDirection(Vector3.forward) * 1000, Color.white);
                Debug.Log("Did not Hit");
            }

            if (hit.collider.gameObject.CompareTag("Enemy"))
            {
                Destroy(hit.collider.gameObject);
            }
            
            if (hit.collider.gameObject.CompareTag("Boss"))
            {
                counter++;
            }

            
            if (hit.collider.gameObject.CompareTag("Cake"))
            {
                if (transform.localScale.x == .5f)
                {
                    transform.Translate(0f,.5f,0f);
                    transform.localScale = new Vector3(1f, 1f, 1f);
                    script.jumpSpeed = 8f;
                }
                else
                {
                    transform.localScale = new Vector3(2f, 2f, 2f);
                    transform.Translate(0f,1f,0f);
                    script.jumpSpeed = 15f;
                }
            }
            
            if (hit.collider.gameObject.CompareTag("Bottle"))
            {
                if (transform.localScale.x == 2f)
                {
                    transform.Translate(0f,-1f,0f);
                    transform.localScale = new Vector3(1f, 1f, 1f);
                    script.jumpSpeed = 8f;
                }
                else
                {
                    transform.localScale = new Vector3(.5f, .5f, .5f);
                    script.jumpSpeed = 3f;
                }
            }

            if (counter > 5)
            {
                Destroy(boss.gameObject);
                foreach (var f in flies)
                {
                    Destroy(f);
                }
            }
        }
        
        if (Input.GetKeyDown(KeyCode.V))
        {
            transform.localScale = new Vector3(.5f, .5f, .5f);
            script.jumpSpeed = 3f;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            transform.localScale = new Vector3(2f, 2f, 2f);
            transform.Translate(0f,1f,0f);
            script.jumpSpeed = 15f;
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (transform.localScale.x == .5f)
            {
                transform.Translate(0f,.5f,0f);
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            
            if (transform.localScale.x == 2f)
            {
                transform.Translate(0f,-1f,0f);
                transform.localScale = new Vector3(1f, 1f, 1f);
            }
            script.jumpSpeed = 8f;  
        }
    }
}
