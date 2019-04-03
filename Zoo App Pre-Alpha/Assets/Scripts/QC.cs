using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QC : MonoBehaviour
{
    //public static int currentLocation { get; private set; }
    public int Question = 0;//currentLocation/*value from AR Scanner*/ - 1 * 5; //Pick starting question
    public Text question;
    public int correctanswer;

    // Start is called before the first frame update
    void Start()
    {
        question.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Question == 0)
        {
            question.text = "Sample Question 0, Ans A";
            correctanswer = 0;
        }
        if (Question == 1)
        {
            question.text = "Sample Question 1, Ans B";
            correctanswer = 1;
        }
        if (Question == 2)
        {
            question.text = "Sample Question 2, Ans C";
            correctanswer = 2;
        }
        if (Question == 3)
        {
            question.text = "Sample Question 3, Ans D";
            correctanswer = 3;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Question = Question + 1;
        }
    }
}