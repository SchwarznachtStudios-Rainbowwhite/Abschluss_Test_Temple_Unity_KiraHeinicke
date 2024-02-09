using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
// VARIABLES VARIABLES VARIABLES

    // UI
    private GameObject _StartScreen;
    private GameObject _FinishScreen;

    public GameObject[] A_PuzzleTut;

    // PuzzleFinish
    public bool[] A_PuzzleFinished;

    // Cam Positions
    private GameObject _MainCamera;
    public GameObject[] A_CameraPosition;

    // Puzzle3
    public int _RayHit;


    // START START START START START
    void Start()
    {
        FindingCalls();

        // set camera to start
        _MainCamera.transform.position = A_CameraPosition[0].transform.position;
        _MainCamera.transform.rotation = A_CameraPosition[0].transform.rotation;


    }

// UPDATE UPDATE UPDATE UPDATE
    void Update()
    {
        CameraPosition();

        if (_RayHit == 4)
        {
            A_PuzzleFinished[2] = true;
        }
    }

// FUNCTIONS FUNCTIONS FUNCTIONS





    // UI BUTTONS
    public void Button_StartGame()
    {
        _StartScreen.SetActive(false);
    }

    // changes camera position when puzzle solved to next puzzle
    // changes tutorial text for puzzles
    // enables end screen when all solved
    public void CameraPosition()
    {
        if (A_PuzzleFinished[0])
        {
            A_PuzzleTut[0].SetActive(false);
            A_PuzzleTut[1].SetActive(true);

            _MainCamera.transform.position = A_CameraPosition[1].transform.position;
            _MainCamera.transform.rotation = A_CameraPosition[1].transform.rotation;

        }
        if (A_PuzzleFinished[1])
        {
            A_PuzzleTut[1].SetActive(false);
            A_PuzzleTut[2].SetActive(true);

            _MainCamera.transform.position = A_CameraPosition[2].transform.position;
            _MainCamera.transform.rotation = A_CameraPosition[2].transform.rotation;


        }
        if (A_PuzzleFinished[2])
        {
            A_PuzzleTut[2].SetActive(false);
            A_PuzzleTut[3].SetActive(true);

            _MainCamera.transform.position = A_CameraPosition[3].transform.position;
            _MainCamera.transform.rotation = A_CameraPosition[3].transform.rotation;


        }
        if (A_PuzzleFinished[3])
        {
            _FinishScreen.SetActive(true);
        }
    }

    public void Restart()
    {
        // Reload Scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    // FINDING CALLS
    public void FindingCalls()
    {
        // UI
        _StartScreen = GameObject.Find("StartBG");
        _FinishScreen = GameObject.Find("FinishBG");
        _FinishScreen.SetActive(false);

        // UI Puzzle explanation
        A_PuzzleTut[0] = GameObject.Find("Puzzle1Tut");
        A_PuzzleTut[1] = GameObject.Find("Puzzle2Tut");
        A_PuzzleTut[1].SetActive(false);
        A_PuzzleTut[2] = GameObject.Find("Puzzle3Tut");
        A_PuzzleTut[2].SetActive(false);
        A_PuzzleTut[3] = GameObject.Find("Puzzle4Tut");
        A_PuzzleTut[3].SetActive(false);

        // CamPositions
        _MainCamera = GameObject.FindGameObjectWithTag("MainCamera");

        A_CameraPosition[0] = GameObject.Find("CamPos1");
        A_CameraPosition[1] = GameObject.Find("CamPos2");
        A_CameraPosition[2] = GameObject.Find("CamPos3");
        A_CameraPosition[3] = GameObject.Find("CamPos4");




    }


}
