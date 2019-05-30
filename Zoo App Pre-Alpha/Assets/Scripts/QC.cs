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
            question.text = "Where do Stanely crane live?";
        }
        //Gibbon
        if (PlayerPrefs.GetInt("Question") == 4)
        {
            question.text = "White-cheeked gibbons are born which color?";
        }
        if (PlayerPrefs.GetInt("Question") == 5)
        {
            question.text = "Which gender of White-cheeked gibbon turns blonde at sexual maturity?";
        }
        //Red River Hog
        if (PlayerPrefs.GetInt("Question") == 6)
        {
            question.text = "Which continent do red river hogs live on?";
        }
        if (PlayerPrefs.GetInt("Question") == 7)
        {
            question.text = "When are red river hogs most active?";
        }
        //Southern White Rhinoceros
        if (PlayerPrefs.GetInt("Question") == 8)
        {
            question.text = "What feature helps identify the southern white rhinoceros?";
        }
        if (PlayerPrefs.GetInt("Question") == 9)
        {
            question.text = "What do southern white rhinoceros use to cool off?";
        }
        //Giraffe
        if (PlayerPrefs.GetInt("Question") == 10)
        {
            question.text = "What do giraffes use to defend themselves?";
        }
        if (PlayerPrefs.GetInt("Question") == 11)
        {
            question.text = "Where are giraffes found?";
        }
        //Zebra
        if (PlayerPrefs.GetInt("Question") == 12)
        {
            question.text = "Why are zebras striped?";
        }
        if (PlayerPrefs.GetInt("Question") == 13)
        {
            question.text = "What do zebras NOT eat?";
        }
        //Ostrich
        if (PlayerPrefs.GetInt("Question") == 14)
        {
            question.text = "A single ostrich egg is equal to how many chicken eggs?";
        }
        if (PlayerPrefs.GetInt("Question") == 15)
        {
            question.text = "How do ostriches hide from predators?";
        }
        //Antelope aka Eland
        if (PlayerPrefs.GetInt("Question") == 16)
        {
            question.text = "Which environment can the eland live in?";
        }
        if (PlayerPrefs.GetInt("Question") == 17)
        {
            question.text = "How long is the eland's gestation period?";
        }
        //Zebra
        if (PlayerPrefs.GetInt("Question") == 18)
        {
            question.text = "Why are zebras striped?";
        }
        if (PlayerPrefs.GetInt("Question") == 19)
        {
            question.text = "Zebras are members of the _____ family that includes horses and donkeys.";
        }
        //Meerkat
        if (PlayerPrefs.GetInt("Question") == 20)
        {
            question.text = "Where are groups of meerkats called?";
        }
        if (PlayerPrefs.GetInt("Question") == 21)
        {
            question.text = "What is the key to meerkat survival?";
        }
        //Saddle-Bill Stork
        if (PlayerPrefs.GetInt("Question") == 22)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 23)
        {
            question.text = "";
        }
        //Cassowary
        if (PlayerPrefs.GetInt("Question") == 24)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 25)
        {
            question.text = "";
        }
        //Kangaroo
        if (PlayerPrefs.GetInt("Question") == 26)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 27)
        {
            question.text = "";
        }
        //Tortoise
        if (PlayerPrefs.GetInt("Question") == 28)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 29)
        {
            question.text = "";
        }
        //Tiger
        if (PlayerPrefs.GetInt("Question") == 30)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 31)
        {
            question.text = "";
        }
        //Andean Bear
        if (PlayerPrefs.GetInt("Question") == 32)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 33)
        {
            question.text = "";
        }
        //Alligator Cove
        if (PlayerPrefs.GetInt("Question") == 34)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 35)
        {
            question.text = "";
        }
        //Rhino Hornbill
        if (PlayerPrefs.GetInt("Question") == 36)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 37)
        {
            question.text = "";
        }
        //Clouded Leopard
        if (PlayerPrefs.GetInt("Question") == 38)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 39)
        {
            question.text = "";
        }
        //Red Panda
        if (PlayerPrefs.GetInt("Question") == 40)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 41)
        {
            question.text = "";
        }
        //Ring-tail Lemur
        if (PlayerPrefs.GetInt("Question") == 42)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 43)
        {
            question.text = "";
        }
        //Duiker
        if (PlayerPrefs.GetInt("Question") == 44)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 45)
        {
            question.text = "";
        }
        //Red Ruffed Lemur
        if (PlayerPrefs.GetInt("Question") == 46)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 47)
        {
            question.text = "";
        }
        //Cougar
        if (PlayerPrefs.GetInt("Question") == 48)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 49)
        {
            question.text = "";
        }
        //Spider Monkey
        if (PlayerPrefs.GetInt("Question") == 50)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 51)
        {
            question.text = "";
        }
        //Porcupine
        if (PlayerPrefs.GetInt("Question") == 52)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 53)
        {
            question.text = "";
        }
        //Tapir
        if (PlayerPrefs.GetInt("Question") == 54)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 55)
        {
            question.text = "";
        }
        //Flamingo
        if (PlayerPrefs.GetInt("Question") == 56)
        {
            question.text = "";
        }
        if (PlayerPrefs.GetInt("Question") == 57)
        {
            question.text = "";
        }
        //Debugging tool, resets question # to 0
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("Question", 0);
            PlayerPrefs.SetInt("Rights", 0);
            PlayerPrefs.SetInt("Wrongs", 0);
        }
    }
}