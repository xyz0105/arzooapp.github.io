using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QC : MonoBehaviour
{
    //public static int currentLocation { get; private set; }
    public int Question = 0;//currentLocation/*value from AR Scanner*/ - 1 * 5; //Pick starting question based on where the user is
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
        if (Question == 0)
        {
            question.text = "Sample Question 0, Ans A";
        }
        if (Question == 1)
        {
            question.text = "Sample Question 1, Ans B";
        }
        if (Question == 2)
        {
            question.text = "Sample Question 2, Ans C";
        }
        if (Question == 3)
        {
            question.text = "Sample Question 3, Ans D";
        }
        //Debugging tool, moves directly to next question when space is pressed
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Question = Question + 1;
        }
    }
}