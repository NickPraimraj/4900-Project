using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sim_One_To_Two : MonoBehaviour
{
    public void Sim_Scene_One_To_Two() {
        SceneManager.LoadScene("SimulationScene2");
    }
    public void Sim_Scene_Two_To_Three() {
        SceneManager.LoadScene("SimulationScene3");
    }
    public void Sim_Scene_Three_To_Four() {
        SceneManager.LoadScene("SimulationScene4");
    }
    public void Sim_Scene_Four_To_Five() {
        SceneManager.LoadScene("SimulationScene5");
    }
    public void Sim_Scene_Five_To_Six() {
        SceneManager.LoadScene("SimulationScene6");
    }
    public void Sim_Scene_Six_To_Seven() {
        SceneManager.LoadScene("SimulationScene7");
    }
    public void Sim_Scene_Seven_To_Eight() {
        SceneManager.LoadScene("SimulationScene8");
    }
    public void Sim_Scene_Eight_To_Nine() {
        SceneManager.LoadScene("SimulationScene9");
    }
    public void Sim_Scene_Nine_To_Ten() {
        SceneManager.LoadScene("SimulationScene10");
    }
    public void Sim_Scene_Ten_To_Eleven() {
        SceneManager.LoadScene("SimulationScene11");
    }
    public void Sim_Scene_Eleven_To_Twelve() {
        SceneManager.LoadScene("SimulationScene12");
    }
    public void End_Simulation() {
        SceneManager.LoadScene("SimulationScoreScene");
    }
    public void Start_Simulation() {
        SceneManager.LoadScene("SimulationScene1");
        PlayerPrefs.SetInt("score", 0);
        //ProductivityBar.instance.setMaxProductivity(100);
        PlayerPrefs.SetInt("productivityValue", 100);
    }
    public void interaction_Screen() {
        SceneManager.LoadScene("UserControls");
    }
    public void Start_Trivia() {
        SceneManager.LoadScene("TriviaSceneQuestion1");
    }
    public void game_Selection() {
        SceneManager.LoadScene("GameSelection");
    }
}
