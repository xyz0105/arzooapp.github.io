using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryControl : MonoBehaviour
{
    //Initialize objects
    public GameObject RhinoButton;
    public GameObject PandaButton;
    public GameObject LeopardButton;
    public GameObject ResetConfirm;

    // Start is called before the first frame update
    void Start()
    {

        //Make sure ResetConfirm pop-up window starts out closed
        ResetConfirm.SetActive(false);

        //Set objects to active or inactive based on completion
        if (PlayerPrefs.GetInt("Unlocked1") == 0)
        {
            RhinoButton.SetActive(false);
        }
        else
        {
            RhinoButton.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked2") == 0)
        {
            PandaButton.SetActive(false);
        }
        else
        {
            PandaButton.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked3") == 0)
        {
            LeopardButton.SetActive(false);
        }
        else
        {
            LeopardButton.SetActive(true);
        }
    }

    public void ChooseProjection(int modelnumber)
    {
        PlayerPrefs.SetInt("ModelNumber", modelnumber);
    }
}
