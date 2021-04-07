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
    public void Level6()
    {
        SceneManager.LoadScene(6);
    }

    public void Level7()
    {
        SceneManager.LoadScene(7);
    }

    public void Level8()
    {
        SceneManager.LoadScene(8);
    }

    public void Level9()
    {
        SceneManager.LoadScene(9);
    }

    public void Level10()
    {
        SceneManager.LoadScene(10);
    }

    public void MediumLevel1()
    {
        SceneManager.LoadScene(11);
    }
    public void MediumLevel2()
    {
        SceneManager.LoadScene(12);
    }
    public void MediumLevel3()
    {
        SceneManager.LoadScene(13);
    }

    public void MediumLevel4()
    {
        SceneManager.LoadScene(14);
    }

    public void MediumLevel5()
    {
        SceneManager.LoadScene(15);
    }

    public void MediumLevel6()
    {
        SceneManager.LoadScene(16);
    }
    public void MediumLevel7()
    {
        SceneManager.LoadScene(17);
    }
    public void MediumLevel8()
    {
        SceneManager.LoadScene(18);
    }

    public void MediumLevel9()
    {
        SceneManager.LoadScene(19);
    }

    public void MediumLevel10()
    {
        SceneManager.LoadScene(20);
    }

    public void HardLevel1()
    {
        SceneManager.LoadScene(21);
    }
    public void HardLevel2()
    {
        SceneManager.LoadScene(22);
    }
    public void HardLevel3()
    {
        SceneManager.LoadScene(23);
    }

    public void HardLevel4()
    {
        SceneManager.LoadScene(24);
    }

    public void HardLevel5()
    {
        SceneManager.LoadScene(25);
    }

    public void HardLevel6()
    {
        SceneManager.LoadScene(26);
    }
    public void HardLevel7()
    {
        SceneManager.LoadScene(27);
    }
    public void HardLevel8()
    {
        SceneManager.LoadScene(28);
    }

    public void HardLevel9()
    {
        SceneManager.LoadScene(29);
    }

    public void HardLevel10()
    {
        SceneManager.LoadScene(30);
    }
}
