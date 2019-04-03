using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AControl : MonoBehaviour
{
    //public static int currentLocation { get; private set; }
    public int Question = 0;//currentLocation/*value from AR Scanner*/ - 1 * 5; //Pick starting question
    public Text answer;
    public bool correctanswer;

    // Start is called before the first frame update
    void Start()
    {
        answer.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Question == 0)
        {
            answer.text = "A";
            correctanswer = true;
        }
        if (Question == 1)
        {
            answer.text = "Sample Question 1, Ans B";
            correctanswer = false;
        }
        if (Question == 2)
        {
            answer.text = "Sample Question 2, Ans C";
            correctanswer = false;
        }
        if (Question == 3)
        {
            answer.text = "Sample Question 3, Ans D";
            correctanswer = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Question = Question + 1;
        }
    }
}