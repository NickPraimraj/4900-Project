using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProductivityBar : MonoBehaviour
{
    public Slider slider;

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
        if (slider.value > 0) {
            slider.value = slider.value - 10;
        }
        
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
