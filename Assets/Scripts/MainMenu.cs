using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("離開遊戲");
        Application.Quit();
    }

    public void Illustrate()
    {
        Debug.Log("叫出遊戲玩法");
    }

    public void BackMenu()
    {
        Debug.Log("回主選單");
        SceneManager.LoadScene(0);
    }
}
