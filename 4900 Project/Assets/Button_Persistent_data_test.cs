using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Persistent_data_test : MonoBehaviour
{
    public void button_Left_Add() {
        ScoreManager.instance.AddPoint(10);
    }    

    public void button_Right_Add(){
        ScoreManager.instance.AddPoint(1);
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
