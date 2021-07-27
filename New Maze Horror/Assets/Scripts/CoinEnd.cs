using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinEnd : MonoBehaviour
{
    public CoinSystem coinSystem;
    public int finishNumber;

    public GameObject exitText;

    void Update()
    {
        if (coinSystem.coinscollected == finishNumber)
        {
            exitText.SetActive(true);
        }
    }
}
