using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Absorb : MonoBehaviour {
    public int score;
    public int shots;
	// Use this for initialization
	void Start () {
        ScoreKeeper sK = FindObjectOfType<ScoreKeeper>();
        score = 0;
        shots = 0;
        if(sK)
        {
            shots = sK.shots;
            score = sK.Score;
            Destroy(sK.gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
