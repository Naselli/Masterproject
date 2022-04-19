using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    // Start is called before the first frame update+
    public GameObject[] gateKeys;
    public int keyCount = 0;
    void Start()
    {
        gateKeys = GameObject.FindGameObjectsWithTag("GateKey");
        keyCount = gateKeys.Length;
    }
    
}
