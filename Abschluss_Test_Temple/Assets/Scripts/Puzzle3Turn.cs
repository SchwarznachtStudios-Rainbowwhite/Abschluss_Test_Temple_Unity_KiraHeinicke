using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle3Turn : MonoBehaviour
{
    // VARIABLES VARIABLES VARIABLES

    public GameManager S_GameManager;

    // Object
    private bool _MouseHeldDown;
    private bool _HitGoal;

    public Material _StatueHitMaterial;

// START START START START START
    void Start()
    {
        S_GameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


    }

    // UPDATE UPDATE UPDATE UPDATE
    void Update()
    {
        TurnStatue();
        GoalRaycast();



    }

// FUNCTIONS FUNCTIONS FUNCTIONS

    private void OnMouseDown()
    {
        _MouseHeldDown = true;
    }

    private void OnMouseUp()
    {
        _MouseHeldDown = false; 

    }

    // turns statue as long as mousebutton is being held and goal hasnt been hit
    public void TurnStatue()
    {
        if (_MouseHeldDown && !_HitGoal)
        {
            transform.Rotate(new Vector3(0, 1, 0));

        }

    }

    // Sends raycast from the statue
    public void GoalRaycast()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);

        // when statue hits goal the first time..
        if (Physics.Raycast(ray, out hit) && !_HitGoal)
        {
            // checks if goal hit
            if (hit.collider.CompareTag("Goal"))
            {
                // changes bool of hit to true
                // changes statue material
                // counter for statue hit +1
                _HitGoal = true;
                GetComponent<Renderer>().material = _StatueHitMaterial;
                S_GameManager._RayHit++;
            }
        }

        Debug.DrawRay(ray.origin, ray.direction * 10);
    }


}
