using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button5UI : MonoBehaviour
{
    public void AdvanceButton() {
        SceneManager.LoadScene("TriviaSceneQuestion5Answer");
    }
}
