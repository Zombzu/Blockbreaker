using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] Paddle padde1;
    [SerializeField] float velocityX = 2f;
    [SerializeField] float velocityY = 15f;
    bool hasStarted = false;

    Vector2 PaddleToBallVector;

	// Use this for initialization
	void Start ()
    {
        PaddleToBallVector = transform.position - padde1.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasStarted)
        {
            LockBalltPaddle();
        }
        LaunchOnClick();
    }

    private void LaunchOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX,velocityY);
            hasStarted = true;
        }
    }

    private void LockBalltPaddle()
    {
        Vector2 PaddlePos = new Vector2(padde1.transform.position.x, padde1.transform.position.y);
        transform.position = PaddlePos + PaddleToBallVector;
    }
}
