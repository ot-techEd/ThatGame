using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreTxt;
    [SerializeField] private TMP_Text highScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.GetScoreManager().OnScoreUpdated += UpdateScoreUI;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScoreUI(int score, int highScore)
    {
        scoreTxt.SetText("Score: " + score.ToString("000"));
        highScoreTxt.SetText("HIghScore: " + highScore.ToString("000"));
    }
}
