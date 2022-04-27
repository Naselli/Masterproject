using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstgate : MonoBehaviour
{

    public GameObject gate;

    public GameObject reset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gate.gameObject);
            Destroy(this.gameObject);
        }
    }
    
}
