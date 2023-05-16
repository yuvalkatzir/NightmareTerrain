using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public string sceneName;
    public void Play() {
        SceneManager.LoadScene(sceneName);
        Game.gameRunning = true;
    }

    public void Quit() {
        Application.Quit();
    }
}
