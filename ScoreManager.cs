using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    private int stars = 0;

    void Start()
    {
        LogScoreAndStars();
    }

    // Function to increase the score when a slice is eaten
    public void AddScore(int points)
    {
        score += points;
        stars = score / 3;
        LogScoreAndStars();
    }

    // Function to log the score and stars in the console
   void LogScoreAndStars()
    {
        Debug.Log("Score: " + score);
        Debug.Log("Stars: " + stars);
    }

}
