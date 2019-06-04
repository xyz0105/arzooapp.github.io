using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AControl : MonoBehaviour
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
            answer.text = "Palm nuts";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "Invasive species taking over";
            correctanswer = false;
        }
        //Stanely Crane
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "Illegal capture";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "Australia";
            correctanswer = false;
        }
        //Gibbon
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "Brachiating";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "Annouce location";
            correctanswer = false;
        }
        //Red River Hog
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "Europe";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "They dig up garden crops.";
            correctanswer = true;
        }
        //Southern White Rhinoceros
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "20 gallons";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            answer.text = "Wealthy people throught Asia believe rhino horns can cure diseases.";
            correctanswer = false;
        }
        //Giraffe
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            answer.text = "To run fast";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            answer.text = "Great spotted one";
            correctanswer = false;
        }
        //Meerkats
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            answer.text = "Shadows";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            answer.text = "Vocalize to alert the mob";
            correctanswer = true;
        }
        //Saddle-Billed Stork
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            answer.text = "The male and female both take care of the chicks.";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            answer.text = "They make no sounds at all.";
            correctanswer = false;
        }
        //Cassowary
        if (PlayerPrefs.GetInt("Question") == 16)
        {
            answer.text = "Black, Striped, Brown";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 17)
        {
            answer.text = "They spend time away from other members except to mate and raise young.";
            correctanswer = true;
        }
        //Kangaroo
        if (PlayerPrefs.GetInt("Question") == 18)
        {
            answer.text = "Tasmanian devil";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 19)
        {
            answer.text = "A dollar bill";
            correctanswer = false;
        }
        //Eland
        if (PlayerPrefs.GetInt("Question") == 20)
        {
            answer.text = "South Africa";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 21)
        {
            answer.text = "By raising their body temperature so they don't sweat";
            correctanswer = true;
        }
        //Bontebok
        if (PlayerPrefs.GetInt("Question") == 22)
        {
            answer.text = "The ability to stab predators with their horns";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 23)
        {
            answer.text = "1930";
            correctanswer = false;
        }
        //Grey crowned crane
        if (PlayerPrefs.GetInt("Question") == 24)
        {
            answer.text = "Population expansion";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 25)
        {
            answer.text = "living fossils";
            correctanswer = true;
        }
        //Ostrich
        if (PlayerPrefs.GetInt("Question") == 26)
        {
            answer.text = "soda can";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 27)
        {
            answer.text = "Overhunting";
            correctanswer = true;
        }
        //Springbok
        if (PlayerPrefs.GetInt("Question") == 28)
        {
            answer.text = "Planking";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 29)
        {
            answer.text = "They pronk too much.";
            correctanswer = false;
        }
        //Zebra
        if (PlayerPrefs.GetInt("Question") == 30)
        {
            answer.text = "This is how they find their mothers.";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 31)
        {
            answer.text = "Rainforests";
            correctanswer = false;
        }
        //Sulcata Tortoise
        if (PlayerPrefs.GetInt("Question") == 32)
        {
            answer.text = "Habitat loss";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 33)
        {
            answer.text = "Catching raindrops";
            correctanswer = false;
        }
        //Sumatran Tiger
        if (PlayerPrefs.GetInt("Question") == 34)
        {
            answer.text = "Habitat loss";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 35)
        {
            answer.text = "Traveling";
            correctanswer = false;
        }
        //Red-footed tortoise
        if (PlayerPrefs.GetInt("Question") == 36)
        {
            answer.text = "With head movements";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 37)
        {
            answer.text = "Habitat loss";
            correctanswer = false;
        }
        //Southern Pudu
        if (PlayerPrefs.GetInt("Question") == 38)
        {
            answer.text = "By chasing out the top predators";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 39)
        {
            answer.text = "White-tailed deer";
            correctanswer = true;
        }
        //Andean Bear
        if (PlayerPrefs.GetInt("Question") == 40)
        {
            answer.text = "Following them with drones";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 41)
        {
            answer.text = "Endangered";
            correctanswer = false;
        }
        //Guinea Pig
        if (PlayerPrefs.GetInt("Question") == 42)
        {
            answer.text = "Peruvian";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 43)
        {
            answer.text = "Peruvian";
            correctanswer = true;
        }
        //Rhino Hornbill
        if (PlayerPrefs.GetInt("Question") == 44)
        {
            answer.text = "Living with rhinoceros";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 45)
        {
            answer.text = "On the branches";
            correctanswer = false;
        }
        //Red Panda
        if (PlayerPrefs.GetInt("Question") == 46)
        {
            answer.text = "more active at dawn and dusk";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 47)
        {
            answer.text = "Habitat loss";
            correctanswer = false;
        }
        //Clouded Leopard
        if (PlayerPrefs.GetInt("Question") == 48)
        {
            answer.text = "Deer";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 49)
        {
            answer.text = "All of the above";
            correctanswer = true;
        }
        //Ring-tailed Lemur
        if (PlayerPrefs.GetInt("Question") == 50)
        {
            answer.text = "South Africa";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 51)
        {
            answer.text = "Sleeping, swimming, and eating";
            correctanswer = false;
        }
        //Yellow-back Duiker
        if (PlayerPrefs.GetInt("Question") == 52)
        {
            answer.text = "Agriculture expansion";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 53)
        {
            answer.text = "Deer, goat, sheep creature";
            correctanswer = false;
        }
        //Red-Ruffed Lemur
        if (PlayerPrefs.GetInt("Question") == 54)
        {
            answer.text = "active at noon";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 55)
        {
            answer.text = "special goggles";
            correctanswer = false;
        }
        //Cougar
        if (PlayerPrefs.GetInt("Question") == 56)
        {
            answer.text = "Habitat loss";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 57)
        {
            answer.text = "Least Concern";
            correctanswer = true;
        }
        //Mexican Spider Monkey
        if (PlayerPrefs.GetInt("Question") == 58)
        {
            answer.text = "3";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 59)
        {
            answer.text = "Highway construction";
            correctanswer = false;
        }
        //Cape Porcupine
        if (PlayerPrefs.GetInt("Question") == 60)
        {
            answer.text = "For their meat";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 61)
        {
            answer.text = "Savannah";
            correctanswer = false;
        }
        //Bard's Tapir and Crested Screamer
        if (PlayerPrefs.GetInt("Question") == 62)
        {
            answer.text = "Near Threatened";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 63)
        {
            answer.text = "Their calls can be heard for several miles";
            correctanswer = true;
        }
        //Caribbean Flamingo
        if (PlayerPrefs.GetInt("Question") == 64)
        {
            answer.text = "Knee";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 65)
        {
            answer.text = "They keep balance better this way";
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