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
    public GameObject referenceObject;
    public GameObject textBox;
    public string animal;
    private bool done;

    void Start()
    {
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

                ScannedTarget scorePointsScript = referenceObject.GetComponent<ScannedTarget>();
                scorePointsScript.AnimalScanned(ScannedTarget);

                PlayerPrefs.SetInt("Question", ScannedTarget);
                done = true;
                animal = "You have scanned the " + animal + "!";

                Text animalText = textBox.GetComponent<Text>();
                animalText.text = animal;

                StartCoroutine(ToQuestion());


                print("Found it!");
            }
        }
    }
    IEnumerator ToQuestion() { yield return new WaitForSeconds(3);
        SceneManager.LoadScene(3);
    }
}
