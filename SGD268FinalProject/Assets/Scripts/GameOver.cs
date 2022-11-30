using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    int waitTime;

    // Update is called once per frame
    void Update()
    {
        waitTime += 1;
        if (waitTime > 1500)
        {
            waitTime = 0;
            GameManager.gm.MainMenu();
        }
    }
}
