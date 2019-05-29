using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BControl : MonoBehaviour
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
            answer.text = "Crackers";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "Habitat loss and lack of food";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "Habitat loss";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "North America";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "Pink";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "Both";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "Asia";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "Sunrise";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "Hooves";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            answer.text = "Shade and mud";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            answer.text = "Long eyelashes";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            answer.text = "South America";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            answer.text = "To have unique fur coloring";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            answer.text = "Meat";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            answer.text = "12";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            answer.text = "They bury their heads in the sand.";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 16)
        {
            answer.text = "Grasslands";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 17)
        {
            answer.text = "5 months";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 18)
        {
            answer.text = "They allow them to run faster.";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 19)
        {
            answer.text = "Equidae";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 20)
        {
            answer.text = "Cast";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 21)
        {
            answer.text = "Being able to dig";
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