using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using System.Collections;

public class Simulation_ScoreManagement : MonoBehaviour
{
    public static Simulation_ScoreManagement instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public ProductivityBar productivityBar;

    int score = 0;
    int highscore = 0;
    string reduce_Amount = "";
    int reduction_Value = 0;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("score",0);
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint(int pointValue) {
        reduce_Amount = productivityBar.reduction_Type();
        if (reduce_Amount == "none") {
            reduction_Value = 1;
        } else {
            reduction_Value = 0;
        }
        score = score + (pointValue * reduction_Value);
        //score = score + pointValue;
        scoreText.text = "Score: " + score.ToString();
        if (highscore < score) {
            PlayerPrefs.SetInt("highscore", score);
        }
        PlayerPrefs.SetInt("score", score);
    }

    private void Awake() {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
