using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutscenemap : MonoBehaviour
{
    public int scenenum;

    void Awake()
    {
        SceneManager.LoadScene(scenenum);
    }
}
