using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{
    // VARIABLES VARIABLES VARIABLES

    //Puzzle Light Sources
    [HideInInspector] public GameObject Light_Cone;
    [HideInInspector] public GameObject Light_Cube;
    [HideInInspector] public GameObject Light_Sphere;
    [HideInInspector] public GameObject Light_Cylinder;

    public bool[] A_LightCorrect;


// START START START START START
    void Start()
    {
        FindingCalls();


    }

// UPDATE UPDATE UPDATE UPDATE
    void Update()
    {

    }

// FUNCTIONS FUNCTIONS FUNCTIONS





    // Finding Calls
    public void FindingCalls()
    {
        //Puzzle LightSources
        Light_Cone = GameObject.FindGameObjectWithTag("Light_Cone");
        Light_Cone.SetActive(false);
        Light_Cube = GameObject.FindGameObjectWithTag("Light_Cube");
        Light_Cube.SetActive(false);
        Light_Sphere = GameObject.FindGameObjectWithTag("Light_Sphere");
        Light_Sphere.SetActive(false);
        Light_Cylinder = GameObject.FindGameObjectWithTag("Light_Cylinder");
        Light_Cylinder.SetActive(false);




    }
}
