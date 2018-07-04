using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LooseCollider : MonoBehaviour {

    private LevelController levelController;

    private void Start()
    {
        levelController = GameObject.FindObjectOfType<LevelController>();
    }
    private void OnCollisionEnter2D(Collision2D trigger)
    {
        print("collision");

        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("trigger");
        levelController.Plane("GameOVer");
    }
}
