using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MediumStarsLevel : MonoBehaviour
{

    public GameObject[] Lev1Stars;

    public Text ScoreLev1;

    public GameObject[] Lev2Stars;

    public Text ScoreLev2;

    public GameObject[] Lev3Stars;

    public Text ScoreLev3;

    public GameObject[] Lev4Stars;

    public Text ScoreLev4;

    public GameObject[] Lev5Stars;

    public Text ScoreLev5;

    // Start is called before the first frame update
    void Start()
    {
        starsLev1();
        starsLev2();
        starsLev3();
        starsLev4();
        starsLev5();
    }

    public void starsLev1()
    {
        ScoreLev1.text = ScoreLev1.text.ToString();

        if(ScoreLev1.text == "15")
        {
            Lev1Stars[0].SetActive(true);
            Lev1Stars[1].SetActive(true);
            Lev1Stars[2].SetActive(true);
            Lev1Stars[3].SetActive(true);
        }
        if (ScoreLev1.text == "10")
        {
            Lev1Stars[0].SetActive(true);
            Lev1Stars[1].SetActive(true);
            Lev1Stars[2].SetActive(false);
            Lev1Stars[3].SetActive(true);
        }
        if (ScoreLev1.text == "5")
        {
            Lev1Stars[0].SetActive(true);
            Lev1Stars[1].SetActive(false);
            Lev1Stars[2].SetActive(false);
            Lev1Stars[3].SetActive(true);
        }
        if (ScoreLev1.text == "00")
        {
            Lev1Stars[0].SetActive(false);
            Lev1Stars[1].SetActive(false);
            Lev1Stars[2].SetActive(false);
            Lev1Stars[3].SetActive(true);
        }

    }
    public void starsLev2()
    {
        ScoreLev2.text = ScoreLev2.text.ToString();

        if (ScoreLev2.text == "15")
        {
            Lev2Stars[0].SetActive(true);
            Lev2Stars[1].SetActive(true);
            Lev2Stars[2].SetActive(true);
            Lev2Stars[3].SetActive(true);
        }
        if (ScoreLev2.text == "10")
        {
            Lev2Stars[0].SetActive(true);
            Lev2Stars[1].SetActive(true);
            Lev2Stars[2].SetActive(false);
            Lev2Stars[3].SetActive(true);
        }
        if (ScoreLev2.text == "5")
        {
            Lev2Stars[0].SetActive(true);
            Lev2Stars[1].SetActive(false);
            Lev2Stars[2].SetActive(false);
            Lev2Stars[3].SetActive(true);
        }
        if (ScoreLev2.text == "00")
        {
            Lev2Stars[0].SetActive(false);
            Lev2Stars[1].SetActive(false);
            Lev2Stars[2].SetActive(false);
            Lev2Stars[3].SetActive(true);
        }

    }

    public void starsLev3()
    {
        ScoreLev3.text = ScoreLev3.text.ToString();

        if (ScoreLev3.text == "15")
        {
            Lev3Stars[0].SetActive(true);
            Lev3Stars[1].SetActive(true);
            Lev3Stars[2].SetActive(true);
            Lev3Stars[3].SetActive(true);
        }
        if (ScoreLev3.text == "10")
        {
            Lev3Stars[0].SetActive(true);
            Lev3Stars[1].SetActive(true);
            Lev3Stars[2].SetActive(false);
            Lev3Stars[3].SetActive(true);
        }
        if (ScoreLev3.text == "5")
        {
            Lev3Stars[0].SetActive(true);
            Lev3Stars[1].SetActive(false);
            Lev3Stars[2].SetActive(false);
            Lev3Stars[3].SetActive(true);
        }
        if (ScoreLev3.text == "00")
        {
            Lev3Stars[0].SetActive(false);
            Lev3Stars[1].SetActive(false);
            Lev3Stars[2].SetActive(false);
            Lev3Stars[3].SetActive(true);
        }

    }

    public void starsLev4()
    {
        ScoreLev4.text = ScoreLev4.text.ToString();

        if (ScoreLev4.text == "15")
        {
            Lev4Stars[0].SetActive(true);
            Lev4Stars[1].SetActive(true);
            Lev4Stars[2].SetActive(true);
            Lev4Stars[3].SetActive(true);
        }
        if (ScoreLev4.text == "10")
        {
            Lev4Stars[0].SetActive(true);
            Lev4Stars[1].SetActive(true);
            Lev4Stars[2].SetActive(false);
            Lev4Stars[3].SetActive(true);
        }
        if (ScoreLev4.text == "5")
        {
            Lev4Stars[0].SetActive(true);
            Lev4Stars[1].SetActive(false);
            Lev4Stars[2].SetActive(false);
            Lev4Stars[3].SetActive(true);
        }
        if (ScoreLev4.text == "00")
        {
            Lev4Stars[0].SetActive(false);
            Lev4Stars[1].SetActive(false);
            Lev4Stars[2].SetActive(false);
            Lev4Stars[3].SetActive(true);
        }

    }

    public void starsLev5()
    {
        ScoreLev5.text = ScoreLev5.text.ToString();

        if (ScoreLev5.text == "15")
        {
            Lev5Stars[0].SetActive(true);
            Lev5Stars[1].SetActive(true);
            Lev5Stars[2].SetActive(true);
            Lev5Stars[3].SetActive(true);
        }
        if (ScoreLev5.text == "10")
        {
            Lev5Stars[0].SetActive(true);
            Lev5Stars[1].SetActive(true);
            Lev5Stars[2].SetActive(false);
            Lev5Stars[3].SetActive(true);
        }
        if (ScoreLev5.text == "5")
        {
            Lev5Stars[0].SetActive(true);
            Lev5Stars[1].SetActive(false);
            Lev5Stars[2].SetActive(false);
            Lev5Stars[3].SetActive(true);
        }
        if (ScoreLev5.text == "00")
        {
            Lev5Stars[0].SetActive(false);
            Lev5Stars[1].SetActive(false);
            Lev5Stars[2].SetActive(false);
            Lev5Stars[3].SetActive(true);
        }

    }
}
