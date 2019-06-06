using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WRATMath : MonoBehaviour
{
    //Pull dependencies
    public Text score;
    public Text wrongs;
    public Text rights;
    public Text completion;
    public int Score;
    public int Completion;
    public GameObject CongratsController;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize text
        score.text = "";
        wrongs.text = "";
        rights.text = "";
        Completion = 0;

        //Calculates
        Score = PlayerPrefs.GetInt("Rights") * 100 + PlayerPrefs.GetInt("Wrongs") * -25;

        //Displays score
        score.text = "Score: " + Score;

        //Debugging values, should be hidden on actual launch of app
        wrongs.text = PlayerPrefs.GetInt("Wrongs") + " Wrongs";
        rights.text = PlayerPrefs.GetInt("Rights") + " Rights";

        //Completion is set to the value of all of the Unlocked PlayerPrefs added together
        for(int i = 0; i < 34; i++)
        {
            Completion += PlayerPrefs.GetInt("Unlocked" + i);
        }
    }

    public void ExitWindow()
    {
        CongratsController.SetActive(false);
        PlayerPrefs.SetInt("Congratulated", 1);
    }

    // Update is called once per frame
    void Update()
    {
        //if score is 6600 (maximum) or higher
        if(Score > 6599)
        {
            //Set the color to gold
            score.color = new Vector4(255f, 0.843f, 0f, 1f);
        }
        else
        {
            //Otherwise make it black
            score.color = Color.black;
        }

        //Set the text to Completion out of 33
        completion.text = "Completion: " + Completion + "/33";

        if (Completion > 32)
        {
            if (PlayerPrefs.GetInt("Congratulated") == 0)
            {
                CongratsController.SetActive(true);
            }
        }
    }
}
