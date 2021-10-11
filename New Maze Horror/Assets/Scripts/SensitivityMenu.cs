using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SensitivityMenu : MonoBehaviour
{
    bool isOpen;

    public GameObject menu;
    public Slider theui;
    public Cameremovement camcont;

    void Start()
    {
        isOpen = false;
        camcont.mouseSensitivity = PlayerPrefs.GetFloat("sensitivity");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Mkey"))
        {
            if (isOpen == false)
            {
                isOpen = true;
                menu.SetActive(true);
                theui.value = PlayerPrefs.GetFloat("sensitivity");
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                isOpen = false;
                menu.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

    public void sensechanged()
    {
        camcont.mouseSensitivity = theui.value;
        PlayerPrefs.SetFloat("sensitivity", theui.value);
    }
}
