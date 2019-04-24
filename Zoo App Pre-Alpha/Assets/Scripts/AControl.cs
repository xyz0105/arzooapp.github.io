using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AControl : MonoBehaviour
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
            answer.text = "Grasses";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "Sponge Bath";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "North America and Europe";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "A3";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "A4";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "A5";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "A6";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "A7";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "A8";
            correctanswer = true;
        }
    }
        public void ChangeToScene(int changeTheScene) {
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