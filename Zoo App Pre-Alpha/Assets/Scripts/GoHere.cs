using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoHere : MonoBehaviour
{

    Vector3 PlayerLocation;
    public int location = 2;
    private int currentLocation;
    public int locationLimit;
    

    /*
        Location Table:
       Integer "location code" for location, name of location, and Coordinates

       0 Offscreen
       1 Red Panda (-192, -29)
       2 Clouded Leopard (-180, -37)
       3 Rhino (138, 132)

        */
    // The target next location selects 
    void Start()
    {
        
        // PlayerPrefs.SetInt("Unlocked1", 0);
        // PlayerPrefs.SetInt("Unlocked2", 0);
        // PlayerPrefs.SetInt("Unlocked3", 0);
        // sets current location to the location code that corrosponds to the last question asked
        currentLocation = (PlayerPrefs.GetInt("Question") / 3) + 1;
        // if no progress is detected it sends the player to a random point
        if (PlayerPrefs.GetInt("Question") == 0 && PlayerPrefs.GetInt("Unlocked3") == 0 && PlayerPrefs.GetInt("Unlocked0") == 0 ) { print("No progress detected"); TestCompletion(Random.Range(1, 4)); }
        // otherwise, imputs current location into TestCompletion function
        else
        {
            TestCompletion(currentLocation);
        }
        
        
    }

    void Update()
    {
        if (CheckCompletion(1) == true) { print(" Panda completed"); }
        if (CheckCompletion(2) == true) { print(" Leopard completed"); }

        //debug tool to reset all progress
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("Unlocked1", 0);
            PlayerPrefs.SetInt("Unlocked2", 0);
            PlayerPrefs.SetInt("Unlocked3", 0);
            PlayerPrefs.SetInt("Rights", 0);
            PlayerPrefs.SetInt("Wrongs", 0);
            PlayerPrefs.SetInt("Question", 0);
            print("All progress reset");
        }

    }
    // Tests whether the location after the current location has been completed. If it has not, sends sign to that location. If it has, tests the location after the next one, etc. If the current location is the last one on the list (number 3), it loops back to location 1.
    void TestCompletion(int location)
    {
        if ((location + 1) > locationLimit) { TestCompletion(0); }
        else
        {
            if (CheckCompletion(location + 1) == false) { MoveSign(location + 1); } else { TestCompletion(location + 1); }
        }
    }

    // MoveSign moves the sign to the predetermined location
    void MoveSign(int locationCode)
    {
     
            Vector3[] xcoordinates = new[] { new Vector3(1000.0f, 0.0f, 0.0f), new Vector3(-192.0f, -29.0f, 0.0f), new Vector3(-134.0f, -46.0f, 0.0f), new Vector3(138.0f, 132.0f, 0.0f) };
            PlayerLocation = xcoordinates[locationCode];
            print("Sign is at location " + locationCode);
            GetComponent<RectTransform>().localPosition = PlayerLocation;
            location = locationCode;
    }

    // Takes location code as an imput, and returns with true or false depending on if that location has been completed.
    bool CheckCompletion(int animal)
    { if (PlayerPrefs.GetInt("Unlocked" + animal) == 1) { return true; } else { return false; }
    }
} 