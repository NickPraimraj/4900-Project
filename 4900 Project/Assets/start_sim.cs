using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class start_sim : MonoBehaviour
{
    public void Start_Simulation() {
        SceneManager.LoadScene("SimulationScene1");
        //PlayerPrefs.SetInt("score", 0);
    }
}
