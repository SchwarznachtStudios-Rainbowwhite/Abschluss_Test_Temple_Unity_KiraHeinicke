using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour
{
// VARIABLES VARIABLES VARIABLES

    // Script
    public GameManager S_GameManager;

    // Puzzle

    public GameObject _PuzzleObjectPrefab;
    public Material _ObjectDoneMaterial;
    public GameObject[] A_PuzzleObject;

    public GameObject[] A_Puzzle1Hints;

    public bool[] A_CorrectPiece;

    public int _CorrectPieceCounter;

// START START START START START
    void Start()
    {
        S_GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


        SpawnObject();
        FindingCalls();

    }

// UPDATE UPDATE UPDATE UPDATE
    void Update()
    {
        // Puzzle done when all 4 pieces correct
        if (_CorrectPieceCounter == 4)
        {
            S_GameManager.A_PuzzleFinished[0] = true;
        }
    }

// FUNCTIONS FUNCTIONS FUNCTIONS

    // Spawn Puzzle Objects in certain area and add them to array
    public void SpawnObject()
    {
        for (int i = 0; i < 4; i++)
        {
            A_PuzzleObject[i] = Instantiate(_PuzzleObjectPrefab, new Vector3(Random.Range(-8, -3), 1, Random.Range(2, 5)), Quaternion.identity);
       
        }
    }


    // Puzzle stuff
    public void LocationCheck()
    {
        for (int i = 0; i < 4; i++)
        {
            // calculate distance between object and the location it belongs
            float distance0 = Vector3.Distance(A_PuzzleObject[0].transform.position, A_Puzzle1Hints[0].transform.position);
            float distance1 = Vector3.Distance(A_PuzzleObject[1].transform.position, A_Puzzle1Hints[1].transform.position);
            float distance2 = Vector3.Distance(A_PuzzleObject[2].transform.position, A_Puzzle1Hints[2].transform.position);
            float distance3 = Vector3.Distance(A_PuzzleObject[3].transform.position, A_Puzzle1Hints[3].transform.position);



            // if distance smaller than limit -> check if rotation correct
            if (distance0 < 0.5 && !A_CorrectPiece[0])
            {
                // hint = 0
                if (A_PuzzleObject[0].transform.localEulerAngles.y == 0 || A_PuzzleObject[1].transform.localEulerAngles.y <= 1 || ( A_PuzzleObject[1].transform.localEulerAngles.y >= 359 && A_PuzzleObject[1].transform.localEulerAngles.y <= 361))
                {
                    // Disable drag n drop script
                    Destroy(A_PuzzleObject[0].GetComponent<DragAndDropTurn>());
                    // set to same x and y position
                    Debug.Log("P1");
                    // change material 
                    A_PuzzleObject[0].GetComponent<Renderer>().material = _ObjectDoneMaterial;

                    A_CorrectPiece[0] = true;
                    _CorrectPieceCounter++;
                }
            }
            if (distance1 < 0.5 && !A_CorrectPiece[1])
            {
                // hint = 90
                if (A_PuzzleObject[1].transform.localEulerAngles.y >= 89 && A_PuzzleObject[1].transform.localEulerAngles.y <= 91)
                {
                    /// Disable drag n drop script
                    Destroy(A_PuzzleObject[1].GetComponent<DragAndDropTurn>());
                    // set to same x and y position
                    Debug.Log("P2");
                    A_PuzzleObject[1].GetComponent<Renderer>().material = _ObjectDoneMaterial;

                    A_CorrectPiece[1] = true;
                    _CorrectPieceCounter++;
                }
            }
            if (distance2 < 0.5 && !A_CorrectPiece[2])
            {
                // hint = 180
                if (A_PuzzleObject[2].transform.localEulerAngles.y >= 179 && A_PuzzleObject[1].transform.localEulerAngles.y <= 181)
                {
                    // Disable drag n drop script
                    Destroy(A_PuzzleObject[2].GetComponent<DragAndDropTurn>());
                    // set to same x and y position
                    Debug.Log("P3");
                    A_PuzzleObject[2].GetComponent<Renderer>().material = _ObjectDoneMaterial;

                    A_CorrectPiece[2] = true;
                    _CorrectPieceCounter++;
                }
            }
            if (distance3 < 0.5 && !A_CorrectPiece[3])
            {
                // hint = 270
                if (A_PuzzleObject[3].transform.localEulerAngles.y >= 269 && A_PuzzleObject[1].transform.localEulerAngles.y <= 271)
                {
                    // Disable drag n drop script
                    Destroy(A_PuzzleObject[3].GetComponent<DragAndDropTurn>());
                    // set to same x and y position
                    Debug.Log("P4");
                    A_PuzzleObject[3].GetComponent<Renderer>().material = _ObjectDoneMaterial;

                    A_CorrectPiece[3] = true;
                    _CorrectPieceCounter++;
                }
            }
        }
        
    }




    // Finding Calls
    public void FindingCalls()
    {

        // UI Puzzle explanation
        A_Puzzle1Hints[0] = GameObject.Find("PuzzleHint1");
        A_Puzzle1Hints[1] = GameObject.Find("PuzzleHint2");
        A_Puzzle1Hints[2] = GameObject.Find("PuzzleHint3");
        A_Puzzle1Hints[3] = GameObject.Find("PuzzleHint4");
    }

}
