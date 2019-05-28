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
        //Hyacinth Macaw
        if (PlayerPrefs.GetInt("Question") == 0)
        {
            question.text = "What is a hyacinth macaw's main food source?";
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            question.text = "Why is the population of hyacinth macaws in the wild rapidly declining?";
        }
        //Stanely Crane
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            question.text = "Which is not a danger Stanely cranes face?";
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            question.text = "Where do Stanely crane live?";
        }
        //Gibbon
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            question.text = "White-cheeked gibbons are born which color?";
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            question.text = "Which gender of White-cheeked gibbon turns blonde at sexual maturity?";
        }
        //Red River Hog
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            question.text = "Which continent do red river hogs live on?";
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            question.text = "When are red river hogs most active?";
        }
        //Southern White Rhinoceros
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            question.text = "What feature helps identify the southern white rhinoceros?";
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            question.text = "What do southern white rhinoceros use to cool off?";
        }
        //Giraffe
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            question.text = "What do giraffes use to defend themselves?";
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            question.text = "Where are giraffes found?";
        }
        //Zebra
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            question.text = "Why are zebras striped?";
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            question.text = "What do zebras NOT eat?";
        }
        //Ostrich
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            question.text = "A single ostrich egg is equal to how many chicken eggs?";
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            question.text = "How do ostriches hide from predators?";
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