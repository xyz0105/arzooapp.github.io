using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DControl : MonoBehaviour
{
    public Text answer;
    private bool correctanswer;

    // Start is called before the first frame update
    void Start()
    {
        answer.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //Set text and whether or not it's the right answer depending on which question is loaded.
        if (PlayerPrefs.GetInt("Question") == 0)
        {
            answer.text = "D0";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "D1";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "D2";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "D3";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "D4";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "D5";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "D6";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "D7";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "D8";
            correctanswer = false;
        }
    }
    public void ChangeToScene(int changeTheScene)
    {
        //When clicked, send to the "Correct" scene if it's right, "Incorrect" scene if it's wrong
        if (correctanswer == true)
        {
            changeTheScene = 4;
        }
        if (correctanswer == false)
        {
            changeTheScene = 5;
        }
        SceneManager.LoadScene(changeTheScene);
    }
}