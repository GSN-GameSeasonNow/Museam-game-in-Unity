using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPaused : MonoBehaviour
{
    public GameObject menuPaused;
    public FirstPersonLook firstPersonLook;
    [SerializeField] KeyCode keyMenu;
    bool isMenuPaused = false;

    public void Start()
    {
        menuPaused.SetActive(false);

    }

    private void Update()
    {
        ActiveMenu();
    }

    void ActiveMenu()
    {
        if (Input.GetKeyDown(keyMenu))
        {
            isMenuPaused = !isMenuPaused;
        }

        if (isMenuPaused)
        {
            menuPaused.SetActive(true);
            firstPersonLook.enabled = false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0f;
        }
        else
        {
            menuPaused.SetActive(false);
            firstPersonLook.enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Time.timeScale = 1f;
        }
    }
    public void MenuContinue()
    {
        isMenuPaused = false;
    }
    public void MenuSeattings()
    {
        SceneManager.LoadScene(1);
    }
    public void MenuExit()
    {
        SceneManager.LoadScene(0);
    }
}