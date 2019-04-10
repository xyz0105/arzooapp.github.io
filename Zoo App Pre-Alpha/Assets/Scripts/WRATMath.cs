using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WRATMath : MonoBehaviour
{
    public Text accuracy;
    public Text wrongs;
    public Text rights;
    public Text total;
    public int AccuracyScore;
    public int Total;

    // Start is called before the first frame update
    void Start()
    {
        accuracy.text = "";
        wrongs.text = "";
        rights.text = "";
        total.text = "";
        //Determine the user's accuracy as their # of correct answers, over their total number of answers, represented as a percentage.
        Total = PlayerPrefs.GetInt("Rights") + PlayerPrefs.GetInt("Wrongs");
        AccuracyScore = PlayerPrefs.GetInt("Rights") * 100 / Total;
        accuracy.text = AccuracyScore + "%";
        wrongs.text = PlayerPrefs.GetInt("Wrongs") + " Wrongs";
        rights.text = PlayerPrefs.GetInt("Rights") + " Rights";
        total.text = "Total: " + Total;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
