using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {
    public GameObject ballPrefab;
    float speed = 3;

	// Use this for initialization
	void Start () {
       
	}

    // Update is called once per frame
    void Update() {
        CheckKey(KeyCode.LeftArrow, Vector3.left * speed);
        CheckKey(KeyCode.RightArrow, Vector3.right * speed);
        CheckKey(KeyCode.UpArrow, Vector3.forward * speed);
        CheckKey(KeyCode.DownArrow, Vector3.back * speed);
       
    }
    void CheckKey(KeyCode kc, Vector3 dir)
    {
        if (Input.GetKeyDown(kc))
        {
            InstBall(dir);
        }
    }

    private void InstBall(Vector3 dir)
    {
        GameObject instance = Instantiate(ballPrefab);
        Rigidbody rb = instance.GetComponent<Rigidbody>();
        rb.velocity = dir * speed;
    }


}
