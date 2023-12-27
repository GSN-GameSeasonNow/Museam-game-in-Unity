using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject Planeseat;
    public GameObject Planeseattwo;
    
    public void planeseat()
    {
        Planeseat.SetActive(true);
        
        Planeseattwo.SetActive(true);
    }
    public void Nonplaneseat()
    {
        Planeseat.SetActive(false);
        
        Planeseattwo.SetActive(false);
    }
    public void MenuMuseam()
    {
        SceneManager.LoadScene(1);
    }

    

    public void Exit()
    {
        Application.Quit();
    }

    public void Menureturn()
    {
        SceneManager.LoadScene(0);
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

  

    
}