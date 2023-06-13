using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene(2);
    }
    public void ExitGame() {
        Application.Quit();
    }
}
