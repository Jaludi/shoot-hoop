using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {
    public GameObject ballPrefab;
    public float speed;
    Camera cam;
    // Use this for initialization
    void Start () {
        cam = GetComponentInChildren<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            
            InstBall();

        }
	}
    private void InstBall()
    {
        GameObject instance = Instantiate(ballPrefab);
        instance.transform.position = transform.position;
        Rigidbody rb = instance.GetComponent<Rigidbody>();
        rb.velocity = cam.transform.rotation * Vector3.forward * speed;
        //print(transform.localRotation.eulerAngles/ 360f );
        //print(cam.transform.localRotation);
        
    }
}
