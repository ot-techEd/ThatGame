using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager scoreManagerInstance;

    public int PlayerScore { get; private set; }
    public int PlayerHighScore { get; private set; }

    public Action<int, int> OnScoreUpdated;

    public static ScoreManager GetScoreManager()
    {
        return scoreManagerInstance;
    }
    private void Awake()
    {
        if (scoreManagerInstance != null && scoreManagerInstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            scoreManagerInstance = this;
        }
    }





    public void UpdatePlayerScore(int score)
    {
        PlayerScore += score;
        CheckHighScore();
        OnScoreUpdated(PlayerScore, PlayerHighScore);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckHighScore()
    {
        if (PlayerScore > PlayerHighScore)
        {
            PlayerHighScore = PlayerScore;
            //Save HighScore
        }
    }
}
