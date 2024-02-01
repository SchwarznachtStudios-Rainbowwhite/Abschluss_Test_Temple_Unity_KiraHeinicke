using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent player;
    public GameObject targetDestination;
    public Animator playerAnimator;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitPoint;

            if (Physics.Raycast(ray, out hitPoint))
            {
                targetDestination.transform.position = hitPoint.point;
                player.SetDestination(hitPoint.point);

            }

        }

        //Movement Abfrage für Animationen
        if(player.velocity != Vector3.zero)
        {
            playerAnimator.SetBool("Walk_FR", true);
        }
        else if (player.velocity == Vector3.zero)
        {
            playerAnimator.SetBool("Walk_FR", false);
        }

    }
}
