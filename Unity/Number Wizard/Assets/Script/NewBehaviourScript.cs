using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    int max;
    int min;
    int guess;
    // Use this for initialization
    void Start () {
        startgame();
    }
	
    void startgame()
    {
        max = 1000;
        min = 1;
        guess = Random.Range(1, 1000);
        print("=====================================================");
        print("Welcom to Number Wizard");
        print("Pick a Number in your head but don't tell me");

        print("The higuest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("is the number higher or lower than" + guess);
        print("Up arrow , down for lower and return for equal");

        max = max + 1;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown (KeyCode.UpArrow))  {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))   {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return)){
            print("I won!");
            startgame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Higuer or lower then" + guess);
        print("Up arrow , down for lower and return for equal");
    }
}
