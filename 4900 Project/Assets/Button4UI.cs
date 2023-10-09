using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button4UI : MonoBehaviour
{
    public void AdvanceButton() {
        SceneManager.LoadScene("TriviaSceneQuestion4Answer");
    }
}
