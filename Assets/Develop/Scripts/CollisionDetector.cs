﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private MovementV2 playerMovement;
    private GameObject groundObject;

    void Start()
    {
        playerMovement = transform.parent.GetComponent<MovementV2>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        print("fd");
        playerMovement.OnGround(groundObject);
        groundObject = col.gameObject;
    }


    private void OnTriggerStay2D(Collider2D col)
    {
        print("yeet");
        playerMovement.OnGround(groundObject);
        groundObject = col.gameObject;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        groundObject = null;
    }
}
