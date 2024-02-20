using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    private static GameManager gameManagerInstance;




    public static GameManager GetGameManager()
    {
        return gameManagerInstance;
    }
    private void Awake()
    {
        if (gameManagerInstance != null && gameManagerInstance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gameManagerInstance = this;
        }
    }

    public void PlayerTookHit(Item itemPlayerTookHitFrom, int score)
    {
        Debug.Log($"Player hit {itemPlayerTookHitFrom.GetItemType()}");
        ScoreManager.GetScoreManager().UpdatePlayerScore(score);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {

    }

    public void EndGame() //When you loose or when you exit game
    {
        SavePlayerData();
    }

    private void SavePlayerData()
    {
        PlayerData playerData = new PlayerData();
        playerData.highScore = ScoreManager.GetScoreManager().PlayerHighScore;
        playerData.userName = "user001";

        string jsonData = JsonUtility.ToJson(playerData);

        Debug.Log(jsonData);
    }
}
