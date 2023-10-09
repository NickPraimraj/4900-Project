using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button4AdvanceUI : MonoBehaviour
{
    public void AdvanceButton() {
        SceneManager.LoadScene("TriviaSceneQuestion5");
    }
}
