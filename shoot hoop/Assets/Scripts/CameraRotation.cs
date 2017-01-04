using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {
    float rotationSpeed = 5f;
    public GameObject cM;
    Camera cam;
    // Use this for initialization
    void Start () {

        cam = GetComponentInChildren<Camera>();
        //transform.localRotation = Quaternion.Euler(0, 90, 0);
	}
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.localRotation = transform.localRotation * Quaternion.Euler(0, mouseX, 0); 
        cam.transform.localRotation = cam.transform.localRotation * Quaternion.Euler(-mouseY, 0, 0);
    }
}
