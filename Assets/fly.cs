using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class fly : MonoBehaviour
{
    public bool tree = false;
    private float f = 0.05f;
    private GameObject trigger;
    void Start()
    {
        transform.Translate(new Vector3(0,-100f,0));
        f = Random.Range(.01f, 0.04f);
        StartCoroutine(change());
    }

    // Update is called once per frame
    void Update()
    {
        if (tree)
        {
            Debug.Log("TREE EVENT");
            transform.Translate(new Vector3(0,100f,0));
            tree = false;
        }
        transform.Translate(new Vector3(0,f,0));
    }

    private IEnumerator  change(){
        yield return new WaitForSeconds(1);
        f = -f;
        StartCoroutine(change());
    }

    
}
