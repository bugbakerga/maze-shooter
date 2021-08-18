using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class totalghostwav : MonoBehaviour
{
    public enemyWaveManager enemyWave;

    void Awake()
    {
        enemyWave.ghostKill();
    }
}
