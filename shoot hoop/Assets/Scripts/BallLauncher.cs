using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
    public GameObject ballPrefab;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) ;
        {
            InstBall();

        }
	}
    private void InstBall()
    {
        GameObject instance = Instantiate(ballPrefab);
        Rigidbody rb = instance.GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward * speed;
    }
}
