using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;

    int score = 0;
    int highscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = "Score: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint(int pointValue) {
        score = score + pointValue;
        scoreText.text = "Score: " + score.ToString();
        if (highscore < score) {
            PlayerPrefs.SetInt("highscore", score);
        }
    }

    private void Awake() {
        instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
