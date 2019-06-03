using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightControl : MonoBehaviour
{
    //When the player gets a question right
    public void PlusOneRight()
    {
        //Give the player 100 points
        PlayerPrefs.SetInt("Rights", PlayerPrefs.GetInt("Rights") + 1);

        //If the Question# is odd
        if (PlayerPrefs.GetInt("Question") % 2 == 1)
        {
            //Set the proper Unlocked# PlayerPref to 1
            PlayerPrefs.SetInt("Unlocked" + ((PlayerPrefs.GetInt("Question") + 1) / 2), 1);
            //Go to Hub/Gallery
            ChangeToScene(7);
        }
        //If the Question# is even
        else
        {
            //Change the Question# by 1
            PlayerPrefs.SetInt("Question", PlayerPrefs.GetInt("Question") + 1);
            //Go back to the Questions
            ChangeToScene(3);
        }
    }
    public void ChangeToScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
    }
}