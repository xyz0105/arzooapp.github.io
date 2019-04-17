using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RightControl : MonoBehaviour
{
    public void PlusOneRight()
    {
        PlayerPrefs.SetInt("Rights", PlayerPrefs.GetInt("Rights") + 1);
        if (PlayerPrefs.GetInt("Question") != 2)
        {
            if (PlayerPrefs.GetInt("Question") != 5)
            {
                if (PlayerPrefs.GetInt("Question") != 8)
                {
                    PlayerPrefs.SetInt("Question", PlayerPrefs.GetInt("Question") + 1);
                    ChangeToScene(3);
                }
                else
                {
                    ChangeToScene(7);
                    PlayerPrefs.SetInt("Unlocked3", 1);
                }
            }
            else
            {
                ChangeToScene(7);
                PlayerPrefs.SetInt("Unlocked2", 1);
            }
        }
        else
        {
            ChangeToScene(7);
            PlayerPrefs.SetInt("Unlocked1", 1);
        }
    }
    public void ChangeToScene(int changeTheScene)
    {
    SceneManager.LoadScene(changeTheScene);
    }
}