using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductivityBar : MonoBehaviour
{
    public static ProductivityBar instance;
    public Slider slider;
    string reduction = "";

    public void setMaxProductivity(int productivity){
        slider.maxValue = productivity;
        slider.value = productivity;
    }
    public void setProductivity(int productivity) {
        slider.value = productivity;
    }

    public float get_Slider_Value(){
        return slider.value;
    }

    public void reduce_Slider_Value(){
        if (slider.value >= 15) {
            slider.value = slider.value - 15;
        }else {
            slider.value = 0;
        }
        PlayerPrefs.SetInt("productivityValue", (int) slider.value);
    }
    public void boost_Slider_Value() {
        if (slider.value + 10 >= 100) {
            slider.value = 100;
        }else {
            slider.value = slider.value + 10;
        }
        PlayerPrefs.SetInt("productivityValue", (int) slider.value);
    }
    public string reduction_Type () {
        if (slider.value >= 50 ) {
            reduction = "none";
            return reduction;
        }else {
            reduction = "all";
            return reduction;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetInt("productivityValue");
    }
    private void Awake() {
        instance = this;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
