using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goldsickle : MonoBehaviour
{
    public GameObject sickle;
    public GameObject buster;
    public Material gold;

    public int done;

    // Start is called before the first frame update
    void Start()
    {
       done = PlayerPrefs.GetInt("alldone");
        if(done > 0)
        {
            sickle.GetComponent<Renderer>().material = gold;
            buster.SetActive(true);
        }
    }

}
