using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalShotsDisplay : MonoBehaviour {
    Text text;
    Absorb abs;
    int shots;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        abs = FindObjectOfType<Absorb>();
        shots = abs.shots;
        text.text = "Shots Attempted: " + shots;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
