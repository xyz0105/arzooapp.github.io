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
            answer.text = "Insects";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = " Illegal pet trade and habitat loss";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "Poisoning";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "South Africa";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "Black";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "Male";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "North America";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "After sunset";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "Gray skin";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            answer.text = "Sponge bath";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            answer.text = "Claws";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            answer.text = "Africa";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            answer.text = "To distract the bees";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            answer.text = "Grass";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            answer.text = "24";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            answer.text = "They curl up into a ball in the grass.";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 16)
        {
            answer.text = "Deserts";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 17)
        {
            answer.text = "9 months";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 18)
        {
            answer.text = "They are fasionistas.";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 19)
        {
            answer.text = "Felidae";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 20)
        {
            answer.text = "Shrewdness";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 21)
        {
            answer.text = "Having a large social group";
            correctanswer = true;
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