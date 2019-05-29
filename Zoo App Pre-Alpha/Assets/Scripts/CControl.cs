﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CControl : MonoBehaviour
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
            answer.text = "Cabbage";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "Overpopulation";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "Africa and South America";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "East Asia";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "Brown";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "Female";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "Africa";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "Mid-day";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "Horns made of keratin";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            answer.text = "Air conditioner";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            answer.text = "Powerful kick";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            answer.text = "Asia";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            answer.text = "To blend into tall grasses and confuse the lions";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            answer.text = "Leaves";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            answer.text = "12";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            answer.text = "They crouch down.";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 16)
        {
            answer.text = "Forests";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 17)
        {
            answer.text = "7 months";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 18)
        {
            answer.text = "The stripes help them to blend into tall grasses and confuse the lions.";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 19)
        {
            answer.text = "Canidae";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 20)
        {
            answer.text = "Mob";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 21)
        {
            answer.text = "Eating insects";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 22)
        {
            answer.text = "";
            correctanswer = ;
        }
        if (PlayerPrefs.GetInt("Question") == 23)
        {
            answer.text = "";
            correctanswer = ;
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
