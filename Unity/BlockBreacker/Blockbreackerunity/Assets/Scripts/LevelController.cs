using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	// Use this for initialization
	void Start () {
  
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Plane(string name)
    {
        SceneManager.LoadScene(name);
        Debug.LogError("u entered in new scene");
    }
    public void LoadNextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        print("Entered in LoadnextLevel");
    }
    public void BrickDestroy()
    {
        if (Brick.CountBreakable <= 0)
        {
            LoadNextlevel();
        }
    }
}