using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreTrackerMedLevels : MonoBehaviour
{
    public Text ScoreTextLev1;
    public Text ScoreTextLev2;
    public Text ScoreTextLev3;
    public Text ScoreTextLev4;
    public Text ScoreTextLev5;
    public Text ScoreTextLev6;
    public Text ScoreTextLev7;
    public Text ScoreTextLev8;
    public Text ScoreTextLev9;
    public Text ScoreTextLev10;

    public Text lev1HighScore;
    public Text lev2HighScore;
    public Text lev3HighScore;
    public Text lev4HighScore;
    public Text lev5HighScore;
    public Text lev6HighScore;
    public Text lev7HighScore;
    public Text lev8HighScore;
    public Text lev9HighScore;
    public Text lev10HighScore;
    // Start is called before the first frame update
    void Start()
    {
        lev1HighScore.text = PlayerPrefs.GetString("MedLevel1").ToString();
        lev2HighScore.text = PlayerPrefs.GetString("MedLevel2").ToString();
        lev3HighScore.text = PlayerPrefs.GetString("MedLevel3").ToString();
        lev4HighScore.text = PlayerPrefs.GetString("MedLevel4").ToString();
        lev5HighScore.text = PlayerPrefs.GetString("MedLevel5").ToString();
        lev6HighScore.text = PlayerPrefs.GetString("MedLevel6").ToString();
        lev7HighScore.text = PlayerPrefs.GetString("MedLevel7").ToString();
        lev8HighScore.text = PlayerPrefs.GetString("MedLevel8").ToString();
        lev9HighScore.text = PlayerPrefs.GetString("MedLevel9").ToString();
        lev10HighScore.text = PlayerPrefs.GetString("MedLevel10").ToString();




    }

    // Update is called once per frame
    void Update()
    {

    }

    public void addLev1Score()
    {
        string score = ScoreTextLev1.text = (int.Parse(ScoreTextLev1.text)).ToString();

        PlayerPrefs.SetString("MedLevel1", score);


    }

    public void addLev2Score()
    {
        string score = ScoreTextLev2.text = (int.Parse(ScoreTextLev2.text)).ToString();

        PlayerPrefs.SetString("MedLevel2", score);


    }

    public void addLev3Score()
    {
        string score = ScoreTextLev3.text = (int.Parse(ScoreTextLev3.text)).ToString();

        PlayerPrefs.SetString("MedLevel3", score);


    }

    public void addLev4Score()
    {
        string score = ScoreTextLev4.text = (int.Parse(ScoreTextLev4.text)).ToString();

        PlayerPrefs.SetString("MedLevel4", score);


    }

    public void addLev5Score()
    {
        string score = ScoreTextLev5.text = (int.Parse(ScoreTextLev5.text)).ToString();

        PlayerPrefs.SetString("MedLevel5", score);


    }

    public void addLev6Score()
    {
        string score = ScoreTextLev6.text = (int.Parse(ScoreTextLev6.text)).ToString();

        PlayerPrefs.SetString("MedLevel6", score);


    }

    public void addLev7Score()
    {
        string score = ScoreTextLev7.text = (int.Parse(ScoreTextLev7.text)).ToString();

        PlayerPrefs.SetString("MedLevel7", score);


    }
    public void addLev8Score()
    {
        string score = ScoreTextLev8.text = (int.Parse(ScoreTextLev8.text)).ToString();

        PlayerPrefs.SetString("MedLevel8", score);


    }

    public void addLev9Score()
    {
        string score = ScoreTextLev9.text = (int.Parse(ScoreTextLev9.text)).ToString();

        PlayerPrefs.SetString("MedLevel9", score);


    }

    public void addLev10Score()
    {
        string score = ScoreTextLev10.text = (int.Parse(ScoreTextLev10.text)).ToString();

        PlayerPrefs.SetString("MedLevel10", score);


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
