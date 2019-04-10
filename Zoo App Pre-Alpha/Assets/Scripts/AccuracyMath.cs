using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccuracyMath : MonoBehaviour
{
    public Text accuracy;
    public int AccuracyScore;

    // Start is called before the first frame update
    void Start()
    {
        accuracy.text = "";
        //Determine the user's accuracy as their # of correct answers, over their total number of answers, represented as a percentage.
        AccuracyScore = (PlayerPrefs.GetInt("Rights")/(PlayerPrefs.GetInt("Rights") + PlayerPrefs.GetInt("Wrongs")))*100;
        accuracy.text = AccuracyScore + "%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
