using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class deathManager : MonoBehaviour
{
    public GameObject player;
    public GameObject deathanim;

    public GameObject gameoverui;

    public void Die()
    {
        deathanim.SetActive(true);
        deathanim.transform.position = player.transform.position;
        deathanim.transform.rotation = player.transform.rotation;
        player.SetActive(false);
        StartCoroutine(deathScreen());
    }

    IEnumerator deathScreen()
    {
        yield return new WaitForSeconds(1f);
        gameoverui.SetActive(true);
        yield return new WaitForSeconds(11f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
