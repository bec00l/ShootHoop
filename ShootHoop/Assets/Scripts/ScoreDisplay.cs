using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {

    public Text text;

    public Text finalText;

    ScoreKeeper scoreKeeper;

    GameManager gameManager;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        gameManager = FindObjectOfType<GameManager>();
    }
	
	// Update is called once per frame
	void Update () {
        if(scoreKeeper != null)
        {
            text.text = "Score:" + scoreKeeper.Score;
        }
        
       
    }
}
