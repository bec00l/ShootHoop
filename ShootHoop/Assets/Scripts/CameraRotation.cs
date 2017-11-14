using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {

       
        var camera = GetComponentInChildren<Camera>();
        var rotationSpeed = 5.0f;
        var mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        var mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;
        transform.localRotation = Quaternion.Euler(0, mouseX, 0) * transform.localRotation;

        camera.transform.localRotation = Quaternion.Euler(-mouseY, 0, 0) * camera.transform.localRotation;
    }
}
