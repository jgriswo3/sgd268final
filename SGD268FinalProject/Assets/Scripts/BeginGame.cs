using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnMouseDown()
    {
        GameManager.gm.StartGame();
    }
}
