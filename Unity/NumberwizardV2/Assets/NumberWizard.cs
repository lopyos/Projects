using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;
    public int MaxGuessesAllowed = 5;

    public Text text;
    // Use this for initialization
    void Start () {
        startgame();
    }
	
    void startgame()
    {
        max = 1000;
        min = 1;
        guess = Random.Range(1, 1000);
        text.text = guess.ToString();

        max = max + 1;
    }

    // Update is called once per frame
    void Update () {                                      // we changed the butons to the mouse click as u can see forward.
        /*if (Input.GetKeyDown (KeyCode.UpArrow))  {
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
        }*/
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max);
        MaxGuessesAllowed = MaxGuessesAllowed - 1;
        text.text = guess.ToString();
        if(MaxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("win");         
        }
    }
}
