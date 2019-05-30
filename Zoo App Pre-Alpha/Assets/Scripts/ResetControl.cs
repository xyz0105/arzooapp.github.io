using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetControl : MonoBehaviour
{
    //Initialize objects
    public GameObject RhinoButton;
    public GameObject PandaButton;
    public GameObject LeopardButton;
    public GameObject ResetConfirm;
    //public GameObject ConfirmParent;

    public void ConfirmReset()
    {
        //Store ResetConfirm pop-up window inside the initialized variable
        /*ConfirmParent = GameObject.Find("ConfirmParent");
        ResetConfirm = ConfirmParent.Find("ResetConfirm");*/

        //Open window
        ResetConfirm.SetActive(true);
    }

    public void ResetDenied()
    {
        //Store ResetConfirm pop-up window inside the initialized variable
        ResetConfirm = GameObject.Find("ResetConfirm");

        //Close window
        ResetConfirm.SetActive(false);
    }

    public void ResetConfirmed()
    {
        //Store actual objects inside the initialized variable
        RhinoButton = GameObject.Find("RhinoButton");
        PandaButton = GameObject.Find("PandaButton");
        LeopardButton = GameObject.Find("LeopardButton");
        ResetConfirm = GameObject.Find("ResetConfirm");

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

        //Close window
        ResetConfirm.SetActive(false);
    }
}
