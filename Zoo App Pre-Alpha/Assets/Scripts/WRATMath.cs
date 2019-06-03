using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WRATMath : MonoBehaviour
{
    public Text score;
    public Text wrongs;
    public Text rights;
    public int Score;

    // Start is called before the first frame update
    void Start()
    {
        score.text = "";
        wrongs.text = "";
        rights.text = "";
        Score = PlayerPrefs.GetInt("Rights") * 100 + PlayerPrefs.GetInt("Wrongs") * -25;
        //Displays score
        score.text = "Score: " + Score;
        //Debugging values, should be hidden on actual launch of app
        wrongs.text = PlayerPrefs.GetInt("Wrongs") + " Wrongs";
        rights.text = PlayerPrefs.GetInt("Rights") + " Rights";
    }

    void Update()
    {
        //When the score is the maximum (or greater)
        if(Score >= 6600)
        {
            //Set the text to gold
            score.color = new Vector4(1f, 0.843f, 0f, 1f);
        }
        else
        {
            //Otherwise, set it to black
            score.color = Color.black;
        }
    }
}
