﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Guide1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene("Guide2");
        }
        if (Input.GetMouseButton(1))
        {
            SceneManager.LoadScene("Game");
        }
    }
}
