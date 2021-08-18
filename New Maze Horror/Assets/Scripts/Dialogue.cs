using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Text dialoguetext;

    [TextArea(3, 10)]
    public string[] sentences;

    public int index;
    public float typingSpeed;

    public GameObject continuebutton;
    public Animator boxanim;

    public GameObject fpscam;
    public GameObject dialoguelogic;

    public GameObject movingcam;
    public Transform[] campos;

    void Start()
    {
        StartCoroutine(Type());
        continuebutton.SetActive(false);
        boxanim.SetBool("isOpen", true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    
    void Update()
    {
        if(dialoguetext.text == sentences[index])
        {
            continuebutton.SetActive(true);
        }
    }

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray()){
            dialoguetext.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence()
    {
        continuebutton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            dialoguetext.text = "";
            StartCoroutine(Type());
            movingcam.transform.position = campos[index].position;
            movingcam.transform.rotation = campos[index].rotation;
        }
        else
        {
            continuebutton.SetActive(false);
            boxanim.SetBool("isOpen", false);
            fpscam.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            dialoguelogic.SetActive(false);
        }
    }
}
