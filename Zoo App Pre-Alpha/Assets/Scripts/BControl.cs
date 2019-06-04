using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BControl : MonoBehaviour
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
            answer.text = "Crackers";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 1)
        {
            answer.text = "Installation of nest boxes";
            correctanswer = false;
        }
        //Stanely Crane
        if (PlayerPrefs.GetInt("Question") == 2)
        {
            answer.text = "Habitat loss";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 3)
        {
            answer.text = "North America";
            correctanswer = false;
        }
        //Gibbon
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            answer.text = "Tree hopping";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            answer.text = "Strengthen bonds";
            correctanswer = false;
        }
        //Red River Hog
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            answer.text = "Asia";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            answer.text = "They eat seeds of crops.";
            correctanswer = false;
        }
        //Southern White Rhinoceros
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            answer.text = "13 gallons";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            answer.text = "There aren't enough conservation efforts.";
            correctanswer = false;
        }
        //Giraffe
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            answer.text = "To confuse predators";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            answer.text = "Tall graceful one";
            correctanswer = false;
        }
        //Meerkats
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            answer.text = "Casts";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            answer.text = "Lead the mob";
            correctanswer = false;
        }
        //Saddle-Bill Stork
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            answer.text = "The males and females have different appearances.";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            answer.text = "They are unable to mimic sounds of other birds.";
            correctanswer = false;
        }
        //Cassowary
        if (PlayerPrefs.GetInt("Question") == 16)
        {
            answer.text = "Black, Brown, Striped";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 17)
        {
            answer.text = "They spend absolutely all their time alone.";
            correctanswer = false;
        }
        //Kangaroo
        if (PlayerPrefs.GetInt("Question") == 18)
        {
            answer.text = "Virginia opossum";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 19)
        {
            answer.text = "A human baby";
            correctanswer = false;
        }
        //Eland
        if (PlayerPrefs.GetInt("Question") == 20)
        {
            answer.text = "Angola";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 21)
        {
            answer.text = "By sitting in rivers and absorbing water through their skin";
            correctanswer = false;
        }
        //Bontebok
        if (PlayerPrefs.GetInt("Question") == 22)
        {
            answer.text = "The ability to run fast";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 23)
        {
            answer.text = "1931";
            correctanswer = true;
        }
        //Grey crowned crane
        if (PlayerPrefs.GetInt("Question") == 24)
        {
            answer.text = "Capture for pet trade and hunting";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 25)
        {
            answer.text = "endangered fossil";
            correctanswer = false;
        }
        //Ostrich
        if (PlayerPrefs.GetInt("Question") == 26)
        {
            answer.text = "school bus";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 27)
        {
            answer.text = "Flooding";
            correctanswer = false;
        }
        //Springbok
        if (PlayerPrefs.GetInt("Question") == 28)
        {
            answer.text = "Prancing";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 29)
        {
            answer.text = "They chase away the farmers' animals.";
            correctanswer = false;
        }
        //Zebra
        if (PlayerPrefs.GetInt("Question") == 30)
        {
            answer.text = "They can find other young zebra to play with.";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 31)
        {
            answer.text = "Savannahs";
            correctanswer = true;
        }
        //Sulcata Tortoise
        if (PlayerPrefs.GetInt("Question") == 32)
        {
            answer.text = "Overgrazing";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 33)
        {
            answer.text = "Eating succulent plants";
            correctanswer = true;
        }
        //Sumatran Tiger
        if (PlayerPrefs.GetInt("Question") == 34)
        {
            answer.text = "Human expansion into tiger territory";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 35)
        {
            answer.text = "Hunting";
            correctanswer = false;
        }
        //Red-footed tortoise
        if (PlayerPrefs.GetInt("Question") == 36)
        {
            answer.text = "With distinct markings on their shells";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 37)
        {
            answer.text = "It's unknown";
            correctanswer = false;
        }
        //Southern Pudu
        if (PlayerPrefs.GetInt("Question") == 38)
        {
            answer.text = "By spreading seeds with their droppings";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 39)
        {
            answer.text = "Opossums";
            correctanswer = false;
        }
        //Andean Bear
        if (PlayerPrefs.GetInt("Question") == 40)
        {
            answer.text = "With infrared lens";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 41)
        {
            answer.text = "Vulnerable";
            correctanswer = true;
        }
        //Guinea Pig
        if (PlayerPrefs.GetInt("Question") == 42)
        {
            answer.text = "Teddy";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 43)
        {
            answer.text = "American";
            correctanswer = false;
        }
        //Rhino Hornbill
        if (PlayerPrefs.GetInt("Question") == 44)
        {
            answer.text = "Horn-like casque on its upper mandible";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 45)
        {
            answer.text = "On the ground in a nest";
            correctanswer = false;
        }
        //Red Panda
        if (PlayerPrefs.GetInt("Question") == 46)
        {
            answer.text = "more active at dusk than dawn";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 47)
        {
            answer.text = "Increase in human need for timber";
            correctanswer = false;
        }
        //Clouded Leopard
        if (PlayerPrefs.GetInt("Question") == 48)
        {
            answer.text = "Wild pigs";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 49)
        {
            answer.text = "Run down the tree head first";
            correctanswer = false;
        }
        //Ring-tailed Lemur
        if (PlayerPrefs.GetInt("Question") == 50)
        {
            answer.text = "Madagascar";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 51)
        {
            answer.text = "Wading, climbing, and sleeping";
            correctanswer = false;
        }
        //Yellow-back Duiker
        if (PlayerPrefs.GetInt("Question") == 52)
        {
            answer.text = "Their monogamous lifestyle";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 53)
        {
            answer.text = "Diver";
            correctanswer = true;
        }
        //Red-Ruffed Lemur
        if (PlayerPrefs.GetInt("Question") == 54)
        {
            answer.text = "active during the night";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 55)
        {
            answer.text = "posterior chambers";
            correctanswer = false;
        }
        //Cougar
        if (PlayerPrefs.GetInt("Question") == 56)
        {
            answer.text = "Perceived threat to humans";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 57)
        {
            answer.text = "Cougar";
            correctanswer = false;
        }
        //Mexican Spider Monkey
        if (PlayerPrefs.GetInt("Question") == 58)
        {
            answer.text = "4";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 59)
        {
            answer.text = "Pet trade";
            correctanswer = false;
        }
        //Cape Porcupine
        if (PlayerPrefs.GetInt("Question") == 60)
        {
            answer.text = "For their ears";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 61)
        {
            answer.text = "Tundra";
            correctanswer = true;
        }
        //Bard's Tapir and Crested Screamer
        if (PlayerPrefs.GetInt("Question") == 62)
        {
            answer.text = "Vulnerable";
            correctanswer = false;
        }
        if (PlayerPrefs.GetInt("Question") == 63)
        {
            answer.text = "They chase tapirs away";
            correctanswer = false;
        }
        //Caribbean Flamingo
        if (PlayerPrefs.GetInt("Question") == 64)
        {
            answer.text = "Ankle";
            correctanswer = true;
        }
        if (PlayerPrefs.GetInt("Question") == 65)
        {
            answer.text = "They fly easier";
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