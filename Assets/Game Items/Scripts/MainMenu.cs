using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void GoHome()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadNextScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0; // Loops the game back to start.
        }
        SceneManager.LoadScene(nextSceneIndex);
    }
    public void LoadPreviousScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int lastSceneIndex = currentSceneIndex - 1;
        if (lastSceneIndex == SceneManager.sceneCountInBuildSettings)
        {
            lastSceneIndex = 0; // Loops the game back to start.
        }
        SceneManager.LoadScene(lastSceneIndex);
    }

    public void LoadCurrentScene()
    {

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void Level1()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
    }

    public void Level3()
    {
        SceneManager.LoadScene(3);
    }

    public void Level4()
    {
        SceneManager.LoadScene(4);
    }

    public void Level5()
    {
        SceneManager.LoadScene(5);
    }

    public void MediumLevel1()
    {
        SceneManager.LoadScene(6);
    }
    public void MediumLevel2()
    {
        SceneManager.LoadScene(7);
    }
    public void MediumLevel3()
    {
        SceneManager.LoadScene(8);
    }

    public void MediumLevel4()
    {
        SceneManager.LoadScene(9);
    }

    public void MediumLevel5()
    {
        SceneManager.LoadScene(10);
    }
}
