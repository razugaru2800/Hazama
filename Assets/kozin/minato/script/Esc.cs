﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Esc : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Escape))
        {
#if UNITY_EDITOR
            EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
      Application.Quit();
#endif
        }

    }
}