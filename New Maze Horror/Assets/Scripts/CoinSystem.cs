using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinSystem : MonoBehaviour
{
    public TextMeshProUGUI coinUi;
    public int coinscollected;
    public int totalCoins;

    public AudioSource speaker;
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {
        coinUi.text = ":" + coinscollected + "/" + totalCoins;
    }

    public void addCoin()
    {
        coinscollected += 1;
        coinUi.text = ":" + coinscollected + "/" + totalCoins;
        speaker.PlayOneShot(sound);
    }
}
