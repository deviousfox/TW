using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Mover playerMover;
    private Camera mainCam;
    void Start()
    {
        mainCam = Camera.main;
        playerMover = FindObjectOfType<Mover>();
    }

    // raycast if presset lmb and send click position to mover
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();
            if (Physics.Raycast(ray,out hit))
            {
                playerMover.MoveTo(hit.point);
            }
        }
    }
}
