using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BControl : MonoBehaviour
{
    //public static int currentLocation { get; private set; }
    public int Question = 0;//currentLocation/*value from AR Scanner*/ - 1 * 5; //Pick starting question
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
        if (Question == 0)
        {
            answer.text = "B0";
            correctanswer = false;
        }
        if (Question == 1)
        {
            answer.text = "B1";
            correctanswer = true;
        }
        if (Question == 2)
        {
            answer.text = "B2";
            correctanswer = false;
        }
        if (Question == 3)
        {
            answer.text = "B3";
            correctanswer = false;
        }
        //Debugging tool, moves directly to next question when space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Question = Question + 1;
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