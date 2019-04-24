using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetControl : MonoBehaviour
{
    //Initialize objects
    public GameObject RhinoButton;
    public GameObject PandaButton;
    public GameObject LeopardButton;

    public void Reset()
    {
        //Store actual objects inside the initialized variable
        RhinoButton = GameObject.Find("RhinoButton");
        PandaButton = GameObject.Find("PandaButton");
        LeopardButton = GameObject.Find("LeopardButton");

        //Reset values
        PlayerPrefs.SetInt("Question", 0);
        PlayerPrefs.SetInt("Rights", 0);
        PlayerPrefs.SetInt("Wrongs", 0);
        PlayerPrefs.SetInt("ModelNumber", 0);
        PlayerPrefs.SetInt("Unlocked1", 0);
        PlayerPrefs.SetInt("Unlocked2", 0);
        PlayerPrefs.SetInt("Unlocked3", 0);

        //Turn buttons off
        RhinoButton.SetActive(false);
        PandaButton.SetActive(false);
        LeopardButton.SetActive(false);
    }
}
