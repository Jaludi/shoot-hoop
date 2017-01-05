using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour {
    public int points = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        ScoreKeeper sK = FindObjectOfType<ScoreKeeper>();
        sK.IncrementScore(points);
    }
}
