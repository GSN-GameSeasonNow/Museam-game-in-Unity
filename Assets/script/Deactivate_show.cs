using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate_show : MonoBehaviour
{
    [SerializeField] ShowObject showObject;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        showObject.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        showObject.enabled = false;
    }
}
