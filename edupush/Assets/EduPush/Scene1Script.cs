﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Scene1Script: MonoBehaviour {
	public Text textArea;
	public string[] strings;
	public float speed = 0.5f;
	// Use this for initialization
	int stringIndex = 0;
	int characterIndex = 0;

	void Start () {

		StartCoroutine (DisplayTimer ());
	}
	IEnumerator DisplayTimer(){
		while (1==1) {
			yield return new WaitForSeconds (speed);
			if (characterIndex > strings [stringIndex].Length) {
				continue;
			}

			textArea.text = strings [stringIndex].Substring (0, characterIndex);
			characterIndex++;
		}
	}



	// Update is called once per frame
	void Update () {

	}
}

