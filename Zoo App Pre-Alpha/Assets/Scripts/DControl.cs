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
            answer.text = "Small insects";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "Illegal pet trade and habitat loss";
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
            answer.text = "Africa";
            correctanswer = true;
        }
        //Gibbon
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "Hanging";
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
            answer.text = "2 gallons";
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
            answer.text = "The one with a purple tongue";
            correctanswer = false;
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
            answer.text = "The male and female take turns guarding the eggs.";
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
            answer.text = "Kenya";
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
        //Grey crowned crane
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
            answer.text = "spiral notebook";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 27)
        {
            answer.text = "Forest fire";
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
            correctanswer = true;
        }
        //Red-footed tortoise
        if (PlayerPrefs.GetInt("Question") == 36)
        {
            answer.text = "All of the above";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 37)
        {
            answer.text = "All of the above";
            correctanswer = false;
        }
        //Sothern Pudu
        if (PlayerPrefs.GetInt("Question") == 38)
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
        //Guinea Pig
        if (PlayerPrefs.GetInt("Question") == 42)
        {
            answer.text = "White Crested";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 43)
        {
            answer.text = "Abyssinian";
            correctanswer = false;
        }
        //Rhino Hornbill
        if (PlayerPrefs.GetInt("Question") == 44)
        {
            answer.text = "Having thick skin like a rhinoceros";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 45)
        {
            answer.text = "With the male";
            correctanswer = false;
        }
        //Red Panda
        if (PlayerPrefs.GetInt("Question") == 46)
        {
            answer.text = "not active at dawn and dusk";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 47)
        {
            answer.text = "All of the above";
            correctanswer = true;
        }
        //Clouded Leopard
        if (PlayerPrefs.GetInt("Question") == 48)
        {
            answer.text = "All of the above";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 49)
        {
            answer.text = "Suspend itself by its hind feet";
            correctanswer = false;
        }
        //Ring-tailed Lemur
        if (PlayerPrefs.GetInt("Question") == 50)
        {
            answer.text = "Australia";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 51)
        {
            answer.text = "Socializing, sunbathing, and swimming";
            correctanswer = false;
        }
        //Yellow-back Duiker
        if (PlayerPrefs.GetInt("Question") == 52)
        {
            answer.text = "Overhunting";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 53)
        {
            answer.text = "One who runs fast";
            correctanswer = false;
        }
        //Red-Ruffed Lemur
        if (PlayerPrefs.GetInt("Question") == 54)
        {
            answer.text = "active at dusk";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 55)
        {
            answer.text = "tapedum lucidum";
            correctanswer = true;
        }
        //Cougar
        if (PlayerPrefs.GetInt("Question") == 56)
        {
            answer.text = "All of the above";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 57)
        {
            answer.text = "Puma";
            correctanswer = false;
        }
        //Mexican Spider Monkey
        if (PlayerPrefs.GetInt("Question") == 58)
        {
            answer.text = "6";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 59)
        {
            answer.text = "All of the above";
            correctanswer = true;
        }
        //Cape Porcupine
        if (PlayerPrefs.GetInt("Question") == 60)
        {
            answer.text = "To keep as pets";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 61)
        {
            answer.text = "Forests";
            correctanswer = false;
        }
        //Bard's Tapir and Crested Screamer
        if (PlayerPrefs.GetInt("Question") == 62)
        {
            answer.text = "Critically Endangered";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 63)
        {
            answer.text = "They guard tapirs from hunters";
            correctanswer = false;
        }
        //Caribbean Flamingo
        if (PlayerPrefs.GetInt("Question") == 64)
        {
            answer.text = "Hip bone";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 65)
        {
            answer.text = "It makes them harder for predators to spot";
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