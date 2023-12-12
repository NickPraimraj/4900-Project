using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 
using System.Collections;

public class Score_Display : MonoBehaviour
{
    public TextMeshProUGUI score_Text_Display;
    public TextMeshProUGUI score_explanation;
    

    // Start is called before the first frame update
    void Start()
    {
        score_Text_Display.text = "Score: " + PlayerPrefs.GetInt("score").ToString();
        int simulation_score = PlayerPrefs.GetInt("score");
        if (simulation_score >= 50) {
            score_explanation.text = "You might be cheating.";
        }else if (simulation_score >= 30 && simulation_score <= 49) {
            score_explanation.text = "Amazing job!";
        }else if (simulation_score >= 20 && simulation_score <= 29) {
            score_explanation.text = "Nice!";
        }else if (simulation_score >= 0 && simulation_score <= 19) {
            score_explanation.text = "You just spammed clicked didn't you?";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
