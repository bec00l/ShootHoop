using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

    public Text text;
    public GameManager gameManager; 
    // Use this for initialization
    void Start () {
        text = GetComponent<Text>();
        gameManager = FindObjectOfType<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "Time:" + (int)gameManager.timeTillNextLevel;
    }
}
