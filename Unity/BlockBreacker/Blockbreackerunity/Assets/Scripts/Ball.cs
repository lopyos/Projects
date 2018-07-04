using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Paddle paddle;
    private bool hasstarted = false;
    private Vector3 paddeltoballVector;

    // Use this for initialization
    void Start()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
       paddeltoballVector = this.transform.position - paddle.transform.position;
        print(paddeltoballVector.y);
    }
    // Update is called once per frame
    void Update()
    {
        if (!hasstarted)
        {

            this.transform.position = paddle.transform.position + paddeltoballVector;

            if (Input.GetMouseButtonDown(0))
                {
                    print("mouseclick lanchball");
                hasstarted = true;
                    this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
             }
        }
    }
}
