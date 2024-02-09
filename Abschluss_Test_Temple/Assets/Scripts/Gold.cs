using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : MonoBehaviour
{
// VARIABLES VARIABLES VARIABLES

    public GameManager S_GameManager;


// START START START START START
    void Start()
    {
        // Script Finding Calls
        S_GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }


    // when clicked on gold, "last puzzle" finished
    public void OnMouseDown()
    {
        
        S_GameManager.A_PuzzleFinished[3] = true;

    }
}
