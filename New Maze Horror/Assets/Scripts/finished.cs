using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finished : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("alldone", 1);
    }
}
