using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// The buttons will also have to advance the scene.
public class Simulation_Score_Points : MonoBehaviour
{
    public ProductivityBar productivityBar;
    public void Add_Points_Low() {
        Simulation_ScoreManagement.instance.AddPoint(5);
        productivityBar.reduce_Slider_Value();
    }
    public void Add_Points_Medium() {
        Simulation_ScoreManagement.instance.AddPoint(10);
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
