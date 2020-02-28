using SonicBloom.Koreo;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private string EventId;
    // Start is called before the first frame update
    void Start()
    {
        Koreographer.Instance.RegisterForEvents(EventId, Jump);
    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
    private void Jump(KoreographyEvent koreoEvent)
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up, ForceMode.Impulse);
    }
}
