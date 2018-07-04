﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

    // Use this for initialization

    void awake() {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }
    void Start() {
 

    }
	
        // Update is called once per frame
	void Update () {

    }
}
