using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private float f = 0.05f;
    void Start()
    {
        f = Random.Range(.01f, 0.04f);
        StartCoroutine(change());
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0,f,0);
    }

    private IEnumerator  change(){
        yield return new WaitForSeconds(1);
        f = -f;
        StartCoroutine(change());
    }
}
