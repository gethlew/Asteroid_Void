using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsLevelHard : MonoBehaviour
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

    public GameObject[] Lev6Stars;

    public Text ScoreLev6;

    public GameObject[] Lev7Stars;

    public Text ScoreLev7;

    public GameObject[] Lev8Stars;

    public Text ScoreLev8;

    public GameObject[] Lev9Stars;

    public Text ScoreLev9;

    public GameObject[] Lev10Stars;

    public Text ScoreLev10;

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
        else if (ScoreLev1.text == "10")
        {
            Lev1Stars[0].SetActive(true);
            Lev1Stars[1].SetActive(true);
            Lev1Stars[2].SetActive(false);
            Lev1Stars[3].SetActive(true);
        }
        else if (ScoreLev1.text == "5")
        {
            Lev1Stars[0].SetActive(true);
            Lev1Stars[1].SetActive(false);
            Lev1Stars[2].SetActive(false);
            Lev1Stars[3].SetActive(true);
        }
        else
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
        else if (ScoreLev2.text == "10")
        {
            Lev2Stars[0].SetActive(true);
            Lev2Stars[1].SetActive(true);
            Lev2Stars[2].SetActive(false);
            Lev2Stars[3].SetActive(true);
        }
        else if (ScoreLev2.text == "5")
        {
            Lev2Stars[0].SetActive(true);
            Lev2Stars[1].SetActive(false);
            Lev2Stars[2].SetActive(false);
            Lev2Stars[3].SetActive(true);
        }
        else
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
        else if (ScoreLev3.text == "10")
        {
            Lev3Stars[0].SetActive(true);
            Lev3Stars[1].SetActive(true);
            Lev3Stars[2].SetActive(false);
            Lev3Stars[3].SetActive(true);
        }
        else if (ScoreLev3.text == "5")
        {
            Lev3Stars[0].SetActive(true);
            Lev3Stars[1].SetActive(false);
            Lev3Stars[2].SetActive(false);
            Lev3Stars[3].SetActive(true);
        }
       else
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
        else if (ScoreLev4.text == "10")
        {
            Lev4Stars[0].SetActive(true);
            Lev4Stars[1].SetActive(true);
            Lev4Stars[2].SetActive(false);
            Lev4Stars[3].SetActive(true);
        }
        else if (ScoreLev4.text == "5")
        {
            Lev4Stars[0].SetActive(true);
            Lev4Stars[1].SetActive(false);
            Lev4Stars[2].SetActive(false);
            Lev4Stars[3].SetActive(true);
        }
        else
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
        else if (ScoreLev5.text == "10")
        {
            Lev5Stars[0].SetActive(true);
            Lev5Stars[1].SetActive(true);
            Lev5Stars[2].SetActive(false);
            Lev5Stars[3].SetActive(true);
        }
        else if (ScoreLev5.text == "5")
        {
            Lev5Stars[0].SetActive(true);
            Lev5Stars[1].SetActive(false);
            Lev5Stars[2].SetActive(false);
            Lev5Stars[3].SetActive(true);
        }
        else
        {
            Lev5Stars[0].SetActive(false);
            Lev5Stars[1].SetActive(false);
            Lev5Stars[2].SetActive(false);
            Lev5Stars[3].SetActive(true);
        }

    }

    public void starsLev6()
    {
        ScoreLev6.text = ScoreLev6.text.ToString();

        if (ScoreLev6.text == "15")
        {
            Lev6Stars[0].SetActive(true);
            Lev6Stars[1].SetActive(true);
            Lev6Stars[2].SetActive(true);
            Lev6Stars[3].SetActive(true);
        }
        else if (ScoreLev6.text == "10")
        {
            Lev6Stars[0].SetActive(true);
            Lev6Stars[1].SetActive(true);
            Lev6Stars[2].SetActive(false);
            Lev6Stars[3].SetActive(true);
        }
        else if (ScoreLev6.text == "5")
        {
            Lev6Stars[0].SetActive(true);
            Lev6Stars[1].SetActive(false);
            Lev6Stars[2].SetActive(false);
            Lev6Stars[3].SetActive(true);
        }
        else
        {
            Lev6Stars[0].SetActive(false);
            Lev6Stars[1].SetActive(false);
            Lev6Stars[2].SetActive(false);
            Lev6Stars[3].SetActive(true);
        }

    }

    public void starsLev7()
    {
        ScoreLev7.text = ScoreLev7.text.ToString();

        if (ScoreLev7.text == "15")
        {
            Lev7Stars[0].SetActive(true);
            Lev7Stars[1].SetActive(true);
            Lev7Stars[2].SetActive(true);
            Lev7Stars[3].SetActive(true);
        }
        else if (ScoreLev7.text == "10")
        {
            Lev7Stars[0].SetActive(true);
            Lev7Stars[1].SetActive(true);
            Lev7Stars[2].SetActive(false);
            Lev7Stars[3].SetActive(true);
        }
        else if (ScoreLev7.text == "5")
        {
            Lev7Stars[0].SetActive(true);
            Lev7Stars[1].SetActive(false);
            Lev7Stars[2].SetActive(false);
            Lev7Stars[3].SetActive(true);
        }
        else
        {
            Lev7Stars[0].SetActive(false);
            Lev7Stars[1].SetActive(false);
            Lev7Stars[2].SetActive(false);
            Lev7Stars[3].SetActive(true);
        }

    }

    public void starsLev8()
    {
        ScoreLev8.text = ScoreLev8.text.ToString();

        if (ScoreLev8.text == "15")
        {
            Lev8Stars[0].SetActive(true);
            Lev8Stars[1].SetActive(true);
            Lev8Stars[2].SetActive(true);
            Lev8Stars[3].SetActive(true);
        }
        else if (ScoreLev8.text == "10")
        {
            Lev8Stars[0].SetActive(true);
            Lev8Stars[1].SetActive(true);
            Lev8Stars[2].SetActive(false);
            Lev8Stars[3].SetActive(true);
        }
        else if (ScoreLev8.text == "5")
        {
            Lev8Stars[0].SetActive(true);
            Lev8Stars[1].SetActive(false);
            Lev8Stars[2].SetActive(false);
            Lev8Stars[3].SetActive(true);
        }
        else
        {
            Lev8Stars[0].SetActive(false);
            Lev8Stars[1].SetActive(false);
            Lev8Stars[2].SetActive(false);
            Lev8Stars[3].SetActive(true);
        }

    }

    public void starsLev9()
    {
        ScoreLev9.text = ScoreLev9.text.ToString();

        if (ScoreLev9.text == "15")
        {
            Lev9Stars[0].SetActive(true);
            Lev9Stars[1].SetActive(true);
            Lev9Stars[2].SetActive(true);
            Lev9Stars[3].SetActive(true);
        }
        else if (ScoreLev9.text == "10")
        {
            Lev9Stars[0].SetActive(true);
            Lev9Stars[1].SetActive(true);
            Lev9Stars[2].SetActive(false);
            Lev9Stars[3].SetActive(true);
        }
        else if (ScoreLev9.text == "5")
        {
            Lev9Stars[0].SetActive(true);
            Lev9Stars[1].SetActive(false);
            Lev9Stars[2].SetActive(false);
            Lev9Stars[3].SetActive(true);
        }
        else
        {
            Lev9Stars[0].SetActive(false);
            Lev9Stars[1].SetActive(false);
            Lev9Stars[2].SetActive(false);
            Lev9Stars[3].SetActive(true);
        }

    }

    public void starsLev10()
    {
        ScoreLev10.text = ScoreLev10.text.ToString();

        if (ScoreLev10.text == "15")
        {
            Lev10Stars[0].SetActive(true);
            Lev10Stars[1].SetActive(true);
            Lev10Stars[2].SetActive(true);
            Lev10Stars[3].SetActive(true);
        }
        else if (ScoreLev10.text == "10")
        {
            Lev10Stars[0].SetActive(true);
            Lev10Stars[1].SetActive(true);
            Lev10Stars[2].SetActive(false);
            Lev10Stars[3].SetActive(true);
        }
        else if (ScoreLev10.text == "5")
        {
            Lev10Stars[0].SetActive(true);
            Lev10Stars[1].SetActive(false);
            Lev10Stars[2].SetActive(false);
            Lev10Stars[3].SetActive(true);
        }
        else
        {
            Lev10Stars[0].SetActive(false);
            Lev10Stars[1].SetActive(false);
            Lev10Stars[2].SetActive(false);
            Lev10Stars[3].SetActive(true);
        }

    }
}
