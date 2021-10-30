using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menulink : MonoBehaviour
{
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
