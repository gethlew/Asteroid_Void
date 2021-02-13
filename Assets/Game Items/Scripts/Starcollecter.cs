using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starcollecter : MonoBehaviour
{
    //Array which stores info about UI stars
    public GameObject[] stars;
    //Keeps count of which stars have been collected
    private int starsCount;

    void Start()
    {
        //Counts the number of objects within a scene with a tag
        starsCount = GameObject.FindGameObjectsWithTag("star").Length;
    }

    public void starsAchieved()
    {
        int starsLeft = GameObject.FindGameObjectsWithTag("star").Length;
        int starsCollected = starsCount - starsLeft;

        float percentage = float.Parse(starsCollected.ToString()) / float.Parse(starsCount.ToString()) * 100f;

        if (percentage < 33f )
        {
            stars[3].SetActive(true);
        }

        if (percentage >= 33f && percentage < 66)
        {
            //one star
            stars[0].SetActive(true);
        }
        else if (percentage >= 66 && percentage < 70)
        {
            //two stars
            stars[0].SetActive(true);
            stars[1].SetActive(true);
        }
        else
        {
            //three stars
            stars[0].SetActive(true);
            stars[1].SetActive(true);
            stars[2].SetActive(true);
          

        }
    }

}
