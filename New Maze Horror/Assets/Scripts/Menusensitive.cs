using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menusensitive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("sensitivity", 300f);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
