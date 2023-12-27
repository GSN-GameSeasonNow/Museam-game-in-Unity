using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_Menu : MonoBehaviour
{
    public GameObject exitUI;

    private void Start()
    {
        exitUI.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            exitUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        exitUI?.SetActive(false);
    }
}
