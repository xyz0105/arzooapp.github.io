using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DControl : MonoBehaviour
{
    public Text answer;
    private bool correctanswer;

    // Start is called before the first frame update
    void Start()
    {
        answer.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        //Set text and whether or not it's the right answer depending on which question is loaded.
        //Hyacinth Macaw
        if (PlayerPrefs.GetInt("Question") == 0)
        {
            answer.text = "Insects";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = " Illegal pet trade and habitat loss";
            correctanswer = true;
        }
        //Stanely Crane
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "Poisoning";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "South Africa";
            correctanswer = true;
        }
        //Gibbon
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "Bending";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "All of the above";
            correctanswer = true;
        }
        //Red River Hog
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "North America";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "They are aggressive towards farmers.";
            correctanswer = false;
        }
        //Southern White Rhinoceros
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "More than 13 cups";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            answer.text = "All of the above";
            correctanswer = true;
        }
        //Giraffe
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            answer.text = "To avoid tripping";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            answer.text = "The one with the purple tongue";
            correctanswer = true;
        }
        //Meerkats
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            answer.text = "Shrewdnesses";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            answer.text = "Fight off the predators alone";
            correctanswer = false;
        }
        //Saddle-Bill Stork
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            answer.text = "The male and female legs look differnt.";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            answer.text = "They only make calls when they are alone.";
            correctanswer = false;
        }
        //Cassowary
        if (PlayerPrefs.GetInt("Question") == 16)
        {
            answer.text = "Striped, Brown, Black";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 17)
        {
            answer.text = "They roam in small clutters.";
            correctanswer = false;
        }
        //Kangaroo
        if (PlayerPrefs.GetInt("Question") == 18)
        {
            answer.text = "Musky rat kangaroo";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 19)
        {
            answer.text = "A standard soda can";
            correctanswer = false;
        }
        //Eland
        if (PlayerPrefs.GetInt("Question") == 20)
        {
            answer.text = "Algeria";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 21)
        {
            answer.text = "By running and cooling off with the wind";
            correctanswer = false;
        }
        //Bontebok
        if (PlayerPrefs.GetInt("Question") == 22)
        {
            answer.text = "The ability to jump high";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 23)
        {
            answer.text = "1933";
            correctanswer = false;
        }
        //Greyt crowned crane
        if (PlayerPrefs.GetInt("Question") == 24)
        {
            answer.text = "All of the above";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 25)
        {
            answer.text = "extinct fossils";
            correctanswer = false;
        }
        //Ostrich
        if (PlayerPrefs.GetInt("Question") == 26)
        {
            answer.text = "Spiral notebook";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 27)
        {
            answer.text = "Forset fire";
            correctanswer = false;
        }
        //Springbok
        if (PlayerPrefs.GetInt("Question") == 28)
        {
            answer.text = "Honking";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 29)
        {
            answer.text = "They migrate by millions on treks.";
            correctanswer = true;
        }
        //Zebra
        if (PlayerPrefs.GetInt("Question") == 30)
        {
            answer.text = "They can hide from the insects.";
            correctanswer = false;
        }        
        if (PlayerPrefs.GetInt("Question") == 31)
        {
            answer.text = "Wetlands";
            correctanswer = false;
        }
        //Sulcata Tortoise
        if (PlayerPrefs.GetInt("Question") == 32)
          {
              answer.text = "All of the above";
              correctanswer = true;
          }
        if (PlayerPrefs.GetInt("Question") == 33)
        {
            answer.text = "Drinking from ponds";
            correctanswer = false;
        }
        //Sumatran Tiger
        if (PlayerPrefs.GetInt("Question") == 34)
        {
            answer.text = "All of the above";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 35)
        {
            answer.text = "All of the above";
            correctanswer = false;
        }
        //Red-footed tortoise
        if (PlayerPrefs.GetInt("Question") == 36)
        {
            answer.text = "All of the above";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 37)
        {
            answer.text = "Both A and C";
            correctanswer = true;
        }
        //Sothern Pudu
        if(PlayerPrefs.GetInt("Question") == 38)
        {
            answer.text = "Decomposing rotten materials";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 39)
        {
            answer.text = "Red squirrels";
            correctanswer = false;
        }
        //Andean Bears
        if (PlayerPrefs.GetInt("Question") == 40)
        {
            answer.text = "By tracking the bear's prey";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 41)
        {
            answer.text = "Least concern";
            correctanswer = false;
        }
    }
      public void ChangeToScene(int changeTheScene)
      {
          //When clicked, send to the "Correct" scene if it's right, "Incorrect" scene if it's wrong
          if (correctanswer == true)
          {
              changeTheScene = 4;
          }
          if (correctanswer == false)
          {
              changeTheScene = 5;
          }
          SceneManager.LoadScene(changeTheScene);
      }
  }
 
 
 
 
 
 