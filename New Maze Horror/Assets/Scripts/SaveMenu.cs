using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveMenu : MonoBehaviour
{
    private int savenum;
    public GameObject continuebutton;

    // Start is called before the first frame update
    void Start()
    {
        savenum = PlayerPrefs.GetInt("LevelSave");
        if(savenum > 0)
        {
            continuebutton.SetActive(true);
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene(savenum);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
