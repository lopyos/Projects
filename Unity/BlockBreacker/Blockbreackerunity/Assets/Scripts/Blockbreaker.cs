using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Blockbreaker : MonoBehaviour {
    public Text lives;
    int NumberOfLives;
    // Use this for initialization
    void Start () {
        NumberOfLives = 5;

        lives.text = ("" +NumberOfLives);

}
	
	// Update is called once per frame
	void Update () {
		
	}
}
