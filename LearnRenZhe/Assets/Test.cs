﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 100, 100, 30), "start"))
        {
            ResourceLoader.Instance.CheckTheVersion(() =>
            {
                Debug.Log("callback");
            });
        }
    }
}
