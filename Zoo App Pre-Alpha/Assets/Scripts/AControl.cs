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
            answer.text = "Palm nuts";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "Invasive species taking over";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "Illegal capture";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "Australia";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "Blonde";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "Neither";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "Europe";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "Early afternoon";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "Square lip";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            answer.text = "Mud and leaf fans";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            answer.text = "Thick fur";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            answer.text = "Europe";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            answer.text = "They are fashionistas";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            answer.text = "Twigs";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            answer.text = "3";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            answer.text = "They put their necks close to the ground.";
            correctanswer = true;
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