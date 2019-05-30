using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QC : MonoBehaviour
{
    public Text question;


    // Start is called before the first frame update
    void Start()
    {
        question.text = "";

    }

    // Update is called once per frame
    void Update()
    {
        //Chooses text to display based on the question number
        //Hyacinth Macaw
        if (PlayerPrefs.GetInt("Question") == 0)
        {
            question.text = "What is a hyacinth macaw's main food source?";
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            question.text = "Why is the population of hyacinth macaws in the wild rapidly declining?";
        }
        //Stanely Crane
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            question.text = "Which is not a danger Stanely cranes face?";
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            question.text = "Where do Stanely cranes live?";
        }
        //Gibbon
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            question.text = "White-cheeked gibbons use their long arms to swing branch to branch called _____.";
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            question.text = "Why do white-cheeked gibbons vocalize?";
        }
        //Red River Hog
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            question.text = "Which continent do red river hogs live on?";
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            question.text = "Why do red river hogs get in conflicts with farmers?";
        }
        //Southern White Rhinoceros
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            question.text = "How many gallons of water can a southern white rhinoceros drink in a day?";
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            question.text = "Why does poaching continue to rise for southern white rhinoceros?";
        }
        //Giraffe
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            question.text = "Why do giraffes walk moving both legs on one side first and then both legs on the other side?";
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            question.text = "Giraffe comes from the Arabic word “xirapha” which means ____________.";
        }
        //Meerkat
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            question.text = "Where are groups of meerkats called?";
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            question.text = "What does the meerkat on sentry duty do?";
        }
        //Saddle-Bill Stork
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            question.text = "Why are saddle-billed storks considered sexually dimorphic?";
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            question.text = "Why are saddle-billed storks “voiceless”?";
        }
        //Cassowary
        if (PlayerPrefs.GetInt("Question") == 16)
        {
            question.text = "Describe the pattern change of the feathers of the cassowary.";
        }
        if (PlayerPrefs.GetInt("Question") == 17)
        {
            question.text = "Why are cassowaries considered solitary animals?";
        }
        //Kangaroo
        if (PlayerPrefs.GetInt("Question") == 18)
        {
            question.text = "Which is the only marsupial in North America?";
        }
        if (PlayerPrefs.GetInt("Question") == 19)
        {
            question.text = "After a 33-day gestation period, the joey is about the size of what?";
        }
        //Eland
        if (PlayerPrefs.GetInt("Question") == 20)
        {
            question.text = "Where would you NOT find an eland?";
        }
        if (PlayerPrefs.GetInt("Question") == 21)
        {
            question.text = "How do elands conserve water?";
        }
        //Bontebok
        if (PlayerPrefs.GetInt("Question") == 22)
        {
            question.text = "Which trait protected the bontebok from extinction?";
        }
        if (PlayerPrefs.GetInt("Question") == 23)
        {
            question.text = "What year was the Bontebok National Park established?";
        }
        //Grey crowned crane
        if (PlayerPrefs.GetInt("Question") == 24)
        {
            question.text = "Why are grey crowned cranes under risk?";
        }
        if (PlayerPrefs.GetInt("Question") == 25)
        {
            question.text = "Grey crowned cranes are _______ _______, originating the same time as tapirs, elephants, bats, horses, and penguins.";
        }
        //Ostrich
        if (PlayerPrefs.GetInt("Question") == 26)
        {
            question.text = "An ostrich’s intestine is as long as a _____ ___to help them digest their food.";
        }
        if (PlayerPrefs.GetInt("Question") == 27)
        {
            question.text = "Why were ostriches almost wiped out in the 1700s?";
        }
        //Springbok
        if (PlayerPrefs.GetInt("Question") == 28)
        {
            question.text = "_______is where springbok repeatedly jump up to 9 feet in the air when startled for playing.";
        }
        if (PlayerPrefs.GetInt("Question") == 29)
        {
            question.text = "What behavior of springbok caused farmers to view them as pests?";
        }
        //Zebra
        if (PlayerPrefs.GetInt("Question") == 30)
        {
            question.text = "How do young zebras benefit from the unique patterns of zebra fur?";
        }
        if (PlayerPrefs.GetInt("Question") == 31)
        {
            question.text = "Where do zebras live?";
        }
        //Sulcata Tortoise
        if (PlayerPrefs.GetInt("Question") == 32)
        {
            question.text = "Why have sulcata tortoise populations been decreasing?";
        }
        if (PlayerPrefs.GetInt("Question") == 33)
        {
            question.text = "How do sulcate tortoises get most of their needed water?";
        }
        //Sumatran Tiger
        if (PlayerPrefs.GetInt("Question") == 34)
        {
            question.text = "Why are Sumatran tigers endangered?";
        }
        if (PlayerPrefs.GetInt("Question") == 35)
        {
            question.text = "How do Sumatran tigers spend time in water?";
        }
        //Red-Footed Tortoise
        if (PlayerPrefs.GetInt("Question") == 36)
        {
            question.text = "How do red-footed tortoises identify each other?";
        }
        if (PlayerPrefs.GetInt("Question") == 37)
        {
            question.text = "How are the red-footed tortoises at risk?";
        }
        //Southern Pudu
        if (PlayerPrefs.GetInt("Question") == 38)
        {
            question.text = "How do pudus help their diverse rainforest habitat?";
        }
        if (PlayerPrefs.GetInt("Question") == 39)
        {
            question.text = "Pudus are close relatives to what animals in Tennessee?";
        }
        //Andean Bear
        if (PlayerPrefs.GetInt("Question") == 40)
        {
            question.text = "How do researchers study Andean bears?";
        }
        if (PlayerPrefs.GetInt("Question") == 41)
        {
            question.text = "What is the conservation status of Andean bears?";
        }
        /*
        //Guinea Pig
        if (PlayerPrefs.GetInt("Question") == 42)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 43)
        {
            question.text = "";
        }
        //Rhino Hornbill
        if (PlayerPrefs.GetInt("Question") == 44)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 45)
        {
            question.text = "";
        }
        //Red Panda
        if (PlayerPrefs.GetInt("Question") == 46)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 47)
        {
            question.text = "";
        }
        //Clouded Leopard
        if (PlayerPrefs.GetInt("Question") == 46)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 47)
        {
            question.text = "";
        }
        //Ring-tailed Lemur
        if (PlayerPrefs.GetInt("Question") == 48)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 49)
        {
            question.text = "";
        }
        //Yellow-backed Duiker
        if (PlayerPrefs.GetInt("Question") == 50)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 51)
        {
            question.text = "";
        }
        //Red-Ruffed Lemur
        if (PlayerPrefs.GetInt("Question") == 52)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 53)
        {
            question.text = "";
        }
        //Cougar
        if (PlayerPrefs.GetInt("Question") == 54)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 55)
        {
            question.text = "";
        }
        //Mexican Spider Monkey
        if (PlayerPrefs.GetInt("Question") == 56)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 57)
        {
            question.text = "";
        }
        //Cape Porcupine
        if (PlayerPrefs.GetInt("Question") == 58)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 59)
        {
            question.text = "";
        }
        //Bard's Tapir and Crested Screamer
        if (PlayerPrefs.GetInt("Question") == 60)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 61)
        {
            question.text = "";
        }
        //Caribbean Flamingo
        if (PlayerPrefs.GetInt("Question") == 62)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 63)
        {
            question.text = "";
        }
        */
        //Debugging tool, resets question # to 0
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("Question", 0);
            PlayerPrefs.SetInt("Rights", 0);
            PlayerPrefs.SetInt("Wrongs", 0);
        }
    }
}