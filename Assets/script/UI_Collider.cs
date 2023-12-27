using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Collider : MonoBehaviour
{
    public GameObject ui;

    private void Start()
    {
        ui.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            ui.SetActive(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        ui.SetActive(false);
    }
}
