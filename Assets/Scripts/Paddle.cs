using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    [SerializeField] float screenWidth = 16f;
    [SerializeField] public float beginX = 1f;
    [SerializeField] public float endX = 15f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        float MousePos = (Input.mousePosition.x / Screen.width)*screenWidth;
        Vector2 PaddlePos = new Vector2(transform.position.x, transform.position.y);
        PaddlePos.x = Mathf.Clamp(MousePos, beginX, endX);
        transform.position = PaddlePos;
	}
}
