using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2_LightSwitch : MonoBehaviour
{
    // VARIABLES VARIABLES VARIABLES

    //Script
    [HideInInspector] public Puzzle2 S_Puzzle2;
    [HideInInspector] public GameManager S_GameManager;





// START START START START START
    void Start()
    {
        // Script Finding Calls
        S_Puzzle2 = GameObject.Find("GameManager").GetComponent<Puzzle2>();
        S_GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


    }

// UPDATE UPDATE UPDATE UPDATE
    void Update()
    {

    }

// FUNCTIONS FUNCTIONS FUNCTIONS

    // Light Switch 
    // Wenn objekt tag hat, schalte dieses licht an/aus
    public void OnMouseDown()
    {
        if (CompareTag("Cone"))
        {
            // Wenn Licht aus + Alle anderen Lichter aus sind
            if (!S_Puzzle2.Light_Cone.active && !S_Puzzle2.A_LightCorrect[1] && !S_Puzzle2.A_LightCorrect[2] && !S_Puzzle2.A_LightCorrect[3])
            {
                // Light an + Licht 0 == an
                S_Puzzle2.Light_Cone.SetActive(true);
                S_Puzzle2.A_LightCorrect[0] = true;
            }
            // Wenn Licht aus + Anderes Licht an
            else if (!S_Puzzle2.Light_Cone.active && (S_Puzzle2.A_LightCorrect[1] || S_Puzzle2.A_LightCorrect[2] || S_Puzzle2.A_LightCorrect[3]))
            {
                // Alle Lichter aus
                S_Puzzle2.Light_Cube.SetActive(false);
                S_Puzzle2.Light_Sphere.SetActive(false);
                S_Puzzle2.Light_Cylinder.SetActive(false);
                S_Puzzle2.Light_Cone.SetActive(false);

                for (int i = 0; i < S_Puzzle2.A_LightCorrect.Length; i++)
                {
                    S_Puzzle2.A_LightCorrect[i] = false;
                }

            }
            // Licht ausschalten
            else 
            {
                S_Puzzle2.Light_Cone.SetActive(false);
                S_Puzzle2.A_LightCorrect[0] = false;

            }
        }
        if (CompareTag("Cube"))
        {
            // Wenn Licht aus 
            if (!S_Puzzle2.Light_Cube.active && !S_Puzzle2.A_LightCorrect[2] && !S_Puzzle2.A_LightCorrect[3])
            {
                // Licht an + Licht 1 == an
                S_Puzzle2.Light_Cube.SetActive(true);
                S_Puzzle2.A_LightCorrect[1] = true;
            }
            // Wenn Licht aus + Licht 0 an
            else if (!S_Puzzle2.Light_Cube.active && S_Puzzle2.A_LightCorrect[0])
            {
                // Licht an + Licht 1 == an
                S_Puzzle2.Light_Cube.SetActive(true);
                S_Puzzle2.A_LightCorrect[1] = true;
            }
            // Wenn Licht aus + Anderes Licht an
            else if (!S_Puzzle2.Light_Cube.active && (S_Puzzle2.A_LightCorrect[2] || S_Puzzle2.A_LightCorrect[3]))
            {
                // Alle Lichter aus
                S_Puzzle2.Light_Cone.SetActive(false);
                S_Puzzle2.Light_Sphere.SetActive(false);
                S_Puzzle2.Light_Cylinder.SetActive(false);
                S_Puzzle2.Light_Cube.SetActive(false);

                for (int i = 0; i < S_Puzzle2.A_LightCorrect.Length; i++)
                {
                    S_Puzzle2.A_LightCorrect[i] = false;
                }

            }
            else
            {
                S_Puzzle2.Light_Cube.SetActive(false);
                S_Puzzle2.A_LightCorrect[1] = false;
            }
            
        }
        if (CompareTag("Sphere"))
        {
            // Wenn Licht aus 
            if (!S_Puzzle2.Light_Sphere.active && !S_Puzzle2.A_LightCorrect[0] && !S_Puzzle2.A_LightCorrect[1] && !S_Puzzle2.A_LightCorrect[3])
            {
                // Licht an + Licht 2 == an
                S_Puzzle2.Light_Sphere.SetActive(true);
                S_Puzzle2.A_LightCorrect[2] = true;
            }
            // Wenn Licht aus + Licht 0/1 an
            else if (!S_Puzzle2.Light_Sphere.active && S_Puzzle2.A_LightCorrect[0] && S_Puzzle2.A_LightCorrect[1])
            {
                // Licht an + Licht 2 == an
                S_Puzzle2.Light_Sphere.SetActive(true);
                S_Puzzle2.A_LightCorrect[2] = true;
            }
            // Wenn Licht aus + Licht 1 oder 3 an + Licht 0 an, Licht 1 aus
            else if (!S_Puzzle2.Light_Sphere.active && (S_Puzzle2.A_LightCorrect[1] || S_Puzzle2.A_LightCorrect[3]) || (S_Puzzle2.A_LightCorrect[0] && !S_Puzzle2.A_LightCorrect[1]))
            {
                // Licht an + Alle Lichter aus
                S_Puzzle2.Light_Cone.SetActive(false);
                S_Puzzle2.Light_Sphere.SetActive(false);
                S_Puzzle2.Light_Cylinder.SetActive(false);
                S_Puzzle2.Light_Cube.SetActive(false);

                for (int i = 0; i < S_Puzzle2.A_LightCorrect.Length; i++)
                {
                    S_Puzzle2.A_LightCorrect[i] = false;
                }

            }
            else
            {
                S_Puzzle2.Light_Sphere.SetActive(false);
                S_Puzzle2.A_LightCorrect[2] = false;
            }
        }
        if (CompareTag("Cylinder"))
        {
            // Wenn Licht aus 
            if (!S_Puzzle2.Light_Cylinder.active && !S_Puzzle2.A_LightCorrect[0] && !S_Puzzle2.A_LightCorrect[1] && !S_Puzzle2.A_LightCorrect[2])
            {
                // Licht an + Licht 2 == an
                S_Puzzle2.Light_Cylinder.SetActive(true);
                S_Puzzle2.A_LightCorrect[3] = true;
            }
            // Wenn Licht aus + Licht 0/1/2 an
            else if (!S_Puzzle2.Light_Cylinder.active && S_Puzzle2.A_LightCorrect[0] && S_Puzzle2.A_LightCorrect[1] && S_Puzzle2.A_LightCorrect[2])
            {
                // Licht an + Licht 2 == an
                S_Puzzle2.Light_Cylinder.SetActive(true);
                S_Puzzle2.A_LightCorrect[3] = true;

                // PUZZLE 2 CORRECT
                S_GameManager.A_PuzzleFinished[1] = true;
                Debug.Log("Puzzle2 Done");
            }
            // Wenn Licht aus + Licht 1 oder 2 an + Licht 0 an, Licht 1 aus 
            else if (!S_Puzzle2.Light_Cylinder.active && (S_Puzzle2.A_LightCorrect[1] || S_Puzzle2.A_LightCorrect[2]) || (S_Puzzle2.A_LightCorrect[0] && !S_Puzzle2.A_LightCorrect[1]))
            {
                // Licht an + Alle Lichter aus
                S_Puzzle2.Light_Cone.SetActive(false);
                S_Puzzle2.Light_Sphere.SetActive(false);
                S_Puzzle2.Light_Cylinder.SetActive(false);
                S_Puzzle2.Light_Cube.SetActive(false);

                for (int i = 0; i < S_Puzzle2.A_LightCorrect.Length; i++)
                {
                    S_Puzzle2.A_LightCorrect[i] = false;
                }

            }
            else
            {
                S_Puzzle2.Light_Cylinder.SetActive(false);
                S_Puzzle2.A_LightCorrect[3] = false;
            }
        }
    }

}

