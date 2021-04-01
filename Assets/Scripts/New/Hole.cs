using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Hole : MonoBehaviour
{
    public Text HoleScore;
    private int nextScene;
    public int Score;
    //public static int Score;
    private void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        Score = 0;
        if (PlayerPrefs.GetInt("Score") != 0)
            Score = PlayerPrefs.GetInt("Score");
        HoleScore.text = "Score: " + Score;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ball" && Manager.NumberShots == 1)
        {
            Score += 400;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }
        else if (collision.gameObject.tag == "Ball" && Manager.NumberShots == 2)
        {
            Score += 250;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }

        else if (collision.gameObject.tag == "Ball" && Manager.NumberShots == 3)
        {
            Score += 150;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }

        else if (collision.gameObject.tag == "Ball" && Manager.NumberShots == 4)
        {
            Score += 100;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }

        else if (collision.gameObject.tag == "Ball" && Manager.NumberShots == 5)
        {
            Score += 80;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }

        else if (collision.gameObject.tag == "Ball" && Manager.NumberShots == 6)
        {
            Score += 70;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }

        else if (collision.gameObject.tag == "Ball" && Manager.NumberShots == 7)
        {
            Score += 60;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }

        else if (collision.gameObject.tag == "Ball" && Manager.NumberShots == 8)
        {
            Score += 50;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }

        else if (collision.gameObject.tag == "Ball" && Manager.NumberShots == 9)
        {
            Score += 40;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }
        else if (collision.gameObject.tag == "Ball" && Manager.NumberShots >= 10)
        {
            Score += 20;
            HoleScore.text = Score.ToString();
            PlayerPrefs.SetInt("Score", Score);
            LoadNextLevel();
        }
        void LoadNextLevel()
        {
            Manager.NumberShots = 0;
            Score = PlayerPrefs.GetInt("Score",0);
            SceneManager.LoadScene(nextScene);
        }

    }



}
