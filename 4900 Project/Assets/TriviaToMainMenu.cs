using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriviaToMainMenu : MonoBehaviour
{
    public void AdvanceButton() {
        SceneManager.LoadScene("GameSelectionScreen");
    }
}
