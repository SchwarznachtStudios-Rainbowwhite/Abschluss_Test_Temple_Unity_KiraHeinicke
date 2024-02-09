using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDropTurn : MonoBehaviour
{
    public Puzzle1 S_Puzzle1;

    private Vector3 mousePosition;
    private Color col;


    public void Start()
    {
        S_Puzzle1 = GameObject.Find("GameManager").GetComponent<Puzzle1>();


    }

    private Vector3 GetMousePos()
    {
        return Camera.main.WorldToScreenPoint(transform.position);
    }

    // when mouse pressed get mouse position
    // rotate by 45 when right mouse clicked
    private void OnMouseDown()
    {
        mousePosition = Input.mousePosition - GetMousePos();

        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(new Vector3(0, 45, 0));

        }


    }

    // Drag object with mouse
    // rotate by 45 when right mouse clicked while dragging
    // calls location check for puzzle pieces
    private void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition - mousePosition);

        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(new Vector3(0, 45, 0));

        }
        S_Puzzle1.LocationCheck();

    }


}
