using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    public Text ScoreTextLev1;
    public Text ScoreTextLev2;
    public Text ScoreTextLev3;

    public Text lev1HighScore;
    public Text lev2HighScore;
    public Text lev3HighScore;
    // Start is called before the first frame update
    void Start()
    {
        lev1HighScore.text = PlayerPrefs.GetString("Level1").ToString();
        lev2HighScore.text = PlayerPrefs.GetString("Level2").ToString();
        lev3HighScore.text = PlayerPrefs.GetString("Level3").ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addLev1Score()
    {
        string score = ScoreTextLev1.text = (int.Parse(ScoreTextLev1.text)).ToString();

        PlayerPrefs.SetString("Level1", score);


    }

    public void addLev2Score()
    {
        string score = ScoreTextLev2.text = (int.Parse(ScoreTextLev2.text)).ToString();

        PlayerPrefs.SetString("Level2", score);


    }

    public void addLev3Score()
    {
        string score = ScoreTextLev3.text = (int.Parse(ScoreTextLev3.text)).ToString();

        PlayerPrefs.SetString("Level3", score);


    }
    public void nextLevel()
    {
        var currentScene = SceneManager.GetActiveScene().buildIndex;
        var nextScene = currentScene + 1;
        SceneManager.LoadScene(nextScene);
    }

    public void ScoresPage()
    {
        SceneManager.LoadScene(2);
    }

    public void Home()
    {
        SceneManager.LoadScene(0);
    }
}
