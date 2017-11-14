using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    public GameManager() {}


    public float timeTillNextLevel = 0.0f;


    // Use this for initialization
    void Start () {
        
    }


    // Update is called once per frame
    void Update () {
        if (timeTillNextLevel > 0)
        {
            timeTillNextLevel -= Time.deltaTime;

            GameOver(timeTillNextLevel);
        }
        
        

    }

    public void PlayGame()
    {
        
        SceneManager.LoadScene(1);
        
        
    }

    public void GameOver(float timeLeft) 
    {
        if (timeLeft <= 0){
            

            
            EndGame();

        }
        
    }

    private void EndGame()
    {
        var scoreKeepers = FindObjectOfType<ScoreKeeper>();
        var lastScene = SceneManager.sceneCountInBuildSettings - 1;

        SceneManager.LoadScene(lastScene);
    }
}
