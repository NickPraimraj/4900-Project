using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartSimulation : MonoBehaviour
{
    public void Start_The_Simulation() {
        SceneManager.LoadScene("SimulationScene1");
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.SetInt("productivityValue", 100);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
