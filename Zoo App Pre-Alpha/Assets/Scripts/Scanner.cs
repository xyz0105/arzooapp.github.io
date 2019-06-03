using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Scanner : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    
    public int ScannedTarget;
    //public GameObject referenceObject;
    public GameObject textBox;
    public string animal;
    private bool done;
    private GameObject warning;
    
    void Start()
    {
        bool focusModeSet = CameraDevice.Instance.SetFocusMode(
    CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        if (!focusModeSet)
        {
            StartCoroutine(ManualFocus());
        }
        warning = GameObject.Find("Warning");
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (done == false)
        {

            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED)
            {

               // ScannedTarget scorePointsScript = referenceObject.GetComponent<ScannedTarget>();
               // scorePointsScript.AnimalScanned(ScannedTarget);

                PlayerPrefs.SetInt("Question", ScannedTarget);
                done = true;
                animal = "You have scanned the " + animal + "!";

                if (PlayerPrefs.GetInt("Unlocked" + ((ScannedTarget/2) + 1)) == 0)
                {

                    Text animalText = textBox.GetComponent<Text>();
                    animalText.text = animal;

                    StartCoroutine(ToQuestion());


                    print("Found it!");
                }
                else { StartCoroutine(InvalidTarget()); print("target already completed"); warning.transform.localScale = new Vector3(1, 1, 1); }
            }
        }
    }
    IEnumerator ToQuestion() { yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
    IEnumerator InvalidTarget() { yield return new WaitForSeconds(5);
        done = false;
            warning.transform.localScale = new Vector3(0, 0, 0); ;
    }
    IEnumerator ManualFocus()  { yield return new WaitForSeconds(1); bool focusModeSet = CameraDevice.Instance.SetFocusMode(
    CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}
