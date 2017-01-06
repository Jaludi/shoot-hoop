using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotsFired : MonoBehaviour {
    Text text;
    ScoreKeeper sK;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
       sK = FindObjectOfType<ScoreKeeper>();
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "Shots: " + sK.shots;
	}
}
