using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CControl : MonoBehaviour
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
            answer.text = "Cabbage";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "Overpopulation";
            correctanswer = false;
        }
        //Stanely Crane
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "Overpopulation";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "East Asia";
            correctanswer = false;
        }
        //Gibbon
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "Vanishing";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "Identify individuals";
            correctanswer = false;
        }
        //Red River Hog
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "Africa";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "They go in farmers' homes.";
            correctanswer = false;
        }
        //Southern White Rhinoceros
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "8 gallons";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            answer.text = "Their horns are a symbol of status for the rich.";
            correctanswer = false;
        }
        //Giraffe
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            answer.text = "To mimic skating";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            answer.text = "The one that walks fast";
            correctanswer = true;
        }
        //Meerkats
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            answer.text = "Mobs";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            answer.text = "Feeds the pups insects";
            correctanswer = false;
        }
        //Saddle-Bill Stork
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            answer.text = "The male and female chicks have the same appearance.";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            answer.text = "They have no functioning muscles in their syrinx and cannot make sounds";
            correctanswer = true;
        }
        //Cassowary
        if (PlayerPrefs.GetInt("Question") == 16)
        {
            answer.text = "Striped, Black, Brown";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 17)
        {
            answer.text = "They hang out in large groups.";
            correctanswer = false;
        }
        //Kangaroo
        if (PlayerPrefs.GetInt("Question") == 18)
        {
            answer.text = "Quokka";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 19)
        {
            answer.text = "A jelly bean";
            correctanswer = true;
        }
        //Eland
        if (PlayerPrefs.GetInt("Question") == 20)
        {
            answer.text = "Zambia";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 21)
        {
            answer.text = "By storing water in their horns";
            correctanswer = false;
        }
        //Bontebok
        if (PlayerPrefs.GetInt("Question") == 22)
        {
            answer.text = "The inability to jump";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 23)
        {
            answer.text = "1932";
            correctanswer = false;
        }
        //Grey crowned crane
        if (PlayerPrefs.GetInt("Question") == 24)
        {
            answer.text = "Being viewed as agricultural pests";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 25)
        {
            answer.text = "extinct cranes";
            correctanswer = false;
        }
        //Ostrich
        if (PlayerPrefs.GetInt("Question") == 26)
        {
            answer.text = "blue whale";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 27)
        {
            answer.text = "Earthquake";
            correctanswer = false;
        }
        //Springbok
        if (PlayerPrefs.GetInt("Question") == 28)
        {
            answer.text = "Pronking";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 29)
        {
            answer.text = "They eat the farmers' fish.";
            correctanswer = false;
        }
        //Zebra
        if (PlayerPrefs.GetInt("Question") == 30)
        {
            answer.text = "They can play hide and seek easily.";
            correctanswer = false;
        }     
        if (PlayerPrefs.GetInt("Question") == 31)
        {
            answer.text = "Tundra";
            correctanswer = false;
        }
        //Sulcata Tortoise
        if (PlayerPrefs.GetInt("Question") == 32)
        {
            answer.text = "Pet trade";
            correctanswer = false;
        }  
        if (PlayerPrefs.GetInt("Question") == 33)
        {
            answer.text = "Eating fruits from fruit trees";
            correctanswer = false;
        }
        //Sumatran Tiger
         if (PlayerPrefs.GetInt("Question") == 34)
         {
             answer.text = "Hunted for fur, skin, and bones";
             correctanswer = false;
         }
         if (PlayerPrefs.GetInt("Question") == 35)
         {
             answer.text = "Cool off";
             correctanswer = false;
         }
         //Red-footed tortoise
         if (PlayerPrefs.GetInt("Question") == 36)
         {
             answer.text = "By the shape of their feet";
             correctanswer = false;
         }
         if (PlayerPrefs.GetInt("Question") == 37)
         {
             answer.text = "Collection for pet trade";
             correctanswer = false;
         }
        //Southern Pudu
         if (PlayerPrefs.GetInt("Question") == 38)
         {
             answer.text = "By eating harmful insects";
             correctanswer = false;
         }
         if (PlayerPrefs.GetInt("Question") == 39)
         {
             answer.text = "Common eastern cottontail";
             correctanswer = false;
         }
         //Andean Bear
         if (PlayerPrefs.GetInt("Question") == 40)
         {
             answer.text = "With radio collars";
             correctanswer = true;
         }
         if (PlayerPrefs.GetInt("Question") == 41)
         {
             answer.text = "Near threatened";
             correctanswer = false;
         }
        //Guinea Pig
        if (PlayerPrefs.GetInt("Question") == 42)
        {
            answer.text = "American";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 43)
        {
            answer.text = "Teddy";
            correctanswer = false;
        }
        //Rhino Hornbill
        if (PlayerPrefs.GetInt("Question") == 44)
        {
            answer.text = "Having colorful feathers";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 45)
        {
            answer.text = "In the tree hole";
            correctanswer = true;
        }
        //Red Panda
        if (PlayerPrefs.GetInt("Question") == 46)
        {
            answer.text = "more active at noon";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 47)
        {
            answer.text = "Increase in human need for animal grazing land";
            correctanswer = false;
        }
        //Clouded Leopard
        if (PlayerPrefs.GetInt("Question") == 48)
        {
            answer.text = "Monkeys";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 49)
        {
            answer.text = "Climb on horizontal branches with its back hanging toward the gound";
            correctanswer = false;
        }
        //Ring-tailed Lemur
        if (PlayerPrefs.GetInt("Question") == 50)
        {
            answer.text = "India";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 51)
        {
            answer.text = "Looking for food, sunbathing, and socializing";
            correctanswer = true;
        }
        //Yellow-back Duiker
        if (PlayerPrefs.GetInt("Question") == 52)
        {
            answer.text = "Overpopulation";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 53)
        {
            answer.text = "False eland";
            correctanswer = false;
        }
        //Red-Ruffed Lemur
        if (PlayerPrefs.GetInt("Question") == 54)
        {
            answer.text = "active during the day";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 55)
        {
            answer.text = "vitreous Humor";
            correctanswer = false;
        }
        //Cougar
        if (PlayerPrefs.GetInt("Question") == 56)
        {
            answer.text = "Perceived threat to livestock";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 57)
        {
            answer.text = "Vulnerable";
            correctanswer = false;
        }
        //Mexican Spider Monkey
        if (PlayerPrefs.GetInt("Question") == 58)
        {
            answer.text = "5";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 59)
        {
            answer.text = "Overhunting";
            correctanswer = false;
        }
        //Cape Porcupine
        if (PlayerPrefs.GetInt("Question") == 60)
        {
            answer.text = "For their feet";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 61)
        {
            answer.text = "Scrubland";
            correctanswer = false;
        }
        //Bard's Tapir and Crested Screamer
        if (PlayerPrefs.GetInt("Question") == 62)
        {
            answer.text = "Endangered";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 63)
        {
            answer.text = "They guard their eggs well";
            correctanswer = false;
        }
        //Caribbean Flamingo
        if (PlayerPrefs.GetInt("Question") == 64)
        {
            answer.text = "Toe";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 65)
        {
            answer.text = "It's easier for them";
            correctanswer = true;
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
