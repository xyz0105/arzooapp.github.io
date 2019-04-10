using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QC : MonoBehaviour
{
    public Text question;
    

    // Start is called before the first frame update
    void Start()
    {
        question.text = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        //Chooses text to display based on the question number
        if (PlayerPrefs.GetInt("Question") == 0)
        {
            question.text = "Sample Question 0, Ans A";
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            question.text = "Sample Question 1, Ans B";
        }
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            question.text = "Sample Question 2, Ans C";
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            question.text = "Sample Question 3, Ans D";
        }
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            question.text = "Sample Question 4, Ans A";
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            question.text = "Sample Question 5, Ans B";
        }
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            question.text = "Sample Question 6, Ans C";
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            question.text = "Sample Question 7, Ans D";
        }
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            question.text = "Sample Question 8, Ans A";
        }
        //Debugging tool, resets question # to 0
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("Question", 0);
            PlayerPrefs.SetInt("Rights", 0);
            PlayerPrefs.SetInt("Wrongs", 0);
        }
    }
}