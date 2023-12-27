using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    public GameObject showObject;
    public float showAtDistance = 0f;
    [SerializeField] FirstPersonLook firstPersonLook;
    public Transform fromTheObject;
    public GameObject Panel;
    public GameObject Image;
    bool isPanel;


    private void OnMouseOver()
    {
        if (fromTheObject)
        {
            Vector3 offset = fromTheObject.position - transform.position;
            float sqrLen = offset.sqrMagnitude;
            if (sqrLen < showAtDistance * showAtDistance)
                showObject.SetActive(true);
        }
    }
    private void OnMouseExit()
    {
        showObject.SetActive(false);
    }

    void Update()
    {
        if (fromTheObject)
        {
            Vector3 offset = fromTheObject.position - transform.position;
            float sqrLen = offset.sqrMagnitude;
            if (sqrLen > showAtDistance * showAtDistance)
                showObject.SetActive(false);
            ActiveMenu();

        }
    }
    void ActiveMenu()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            isPanel = !isPanel;
        }

        if (isPanel)
        {
            Panel.SetActive(true);
            Image.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0f;
        }
        else
        {
            Panel.SetActive(false);
            Image.SetActive(true);
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 1f;
        }
    }
}
