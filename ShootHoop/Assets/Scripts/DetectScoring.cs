using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectScoring : MonoBehaviour {
    public int pointValue = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        var scoreKeeper = FindObjectOfType<ScoreKeeper>();
        scoreKeeper.IncrementScore(pointValue);
    }
}
