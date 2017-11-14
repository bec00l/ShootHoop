using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour, IDestroyer {
    private ScoreKeeper _scoreKeeper;
    public void DestroyObject(GameObject gameObject)
    {
        Destroy(gameObject);
    }

    // Use this for initialization
    void Start () {
        _scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
      
      DestroyObject(collision.gameObject);
    }

    private void DetermineGameOver()
    {
        
    }
}
