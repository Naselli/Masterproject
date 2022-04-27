using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject gate;
    private Gate g;
    private GameObject[] trees;
    private GameObject bluegate;

    private void Start()
    {
        g = gate.GetComponent<Gate>();
        trees = GameObject.FindGameObjectsWithTag("flying");
        bluegate = GameObject.FindGameObjectWithTag("BlueGate");
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GateKey"))
        {
            Debug.Log("HIT OBJECT");
            g.keyCount--;
            if (g.keyCount <= 0) 
            {
                Destroy(g.gameObject);
                
            }
            Destroy(collision.gameObject);
        }
       
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TreeEvent"))
        {
            Debug.Log("Tree Enter trigger event ");
            foreach (GameObject g in trees)
            {
                g.GetComponent<fly>().tree = true;
            }
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("BlueGateTrigger"))
        {
            Destroy(bluegate);
        }
    }
}
