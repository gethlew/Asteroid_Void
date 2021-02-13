using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public GameObject LevelDialog;
    public GameObject UIButt;
    public GameObject Hearts;
    public GameObject LevelFailed;
    public Text LevelStatus;
    public Text scoreText;

    public static UIHandler instance;

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    public void ShowLevelDialog(string status,string scores)
    {
        GetComponent<Starcollecter>().starsAchieved();
        LevelDialog.SetActive(true);
        UIButt.SetActive(false);
        Hearts.SetActive(false);
        LevelStatus.text = status;
        scoreText.text = scores;

    }

    public void ShowLevelDialogFailed()
    {
        LevelFailed.SetActive(true);
        UIButt.SetActive(false);
        Hearts.SetActive(false);
    }

}
