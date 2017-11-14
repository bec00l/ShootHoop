using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLauncher : MonoBehaviour {

    public GameObject ballPrefab;
    public float speed = 20.0f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SpawnBallOnFireOne();
    }

    void SpawnBallOnFireOne()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            
            var instance = Instantiate(ballPrefab);

            instance.transform.position = transform.position;
            var rigidBody = instance.GetComponent<Rigidbody>();
            var camera = GetComponentInChildren<Camera>();
            rigidBody.velocity = camera.transform.rotation * Vector3.forward * speed;
        }

    }
}
