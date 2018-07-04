using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {


    public LevelManager levelmanager;

    

    public void loadlevel(string plane)
    {
        SceneManager.LoadScene(plane);
    }
}
