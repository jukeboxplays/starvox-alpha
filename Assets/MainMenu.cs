using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public static bool playStarted = false;
    public static int playCount = 0;

    public void StartGame() {

        Debug.Log("Entrar em: JOGAR");

        playStarted = true;
        playCount += 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void StartCredits()
    {
        Debug.Log("Entrar em: CREDITOS");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
