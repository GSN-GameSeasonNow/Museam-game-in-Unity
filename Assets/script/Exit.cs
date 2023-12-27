using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour

    
{
    public GameObject Canvas;
    public GameObject FonScrollStal;
    private bool paused = false;



    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.E))
            if (!Canvas.activeSelf)
            {
                Canvas.SetActive(true);
                Cursor.visible = true;
                Screen.lockCursor = false;
            }
            else
            {
                Cursor.visible = false;
                Canvas.SetActive(false);
                Screen.lockCursor = true;
            }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (!paused)
            {
                Time.timeScale = 0;
                paused = true;
                Canvas.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                paused = false;
                Canvas.SetActive(false);
            }
        }

        


    }
}
