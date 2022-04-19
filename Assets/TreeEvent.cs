using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class TreeEvent : MonoBehaviour
{
    public bool tree = false;

    private Transform t;

    private void Start()
    {
        t = transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (tree)
        {
            Debug.Log("TREE EVENT");
            transform.Translate(new Vector3(0,-.2f,0));
            transform.Rotate(new Vector3(-100, 0, 0));
            tree = false;
        }
    }
}
