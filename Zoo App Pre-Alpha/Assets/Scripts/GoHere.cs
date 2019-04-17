using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoHere : MonoBehaviour
{

    Vector3 PlayerLocation;
    public int location = 2;
    private int currentLocation;

    /*
        Location Table:
       Integer "location code" for location, name of location, and Coordinates

       0 Offscreen
       1 Panda (43, -56)
       2 Leopard (-180, -37)
       3 Rhino (57, 47)

        */
    // The target next location selects 
    void Start()
    {
        // PlayerPrefs.SetInt("Unlocked1", 0);
        // PlayerPrefs.SetInt("Unlocked2", 0);
        // PlayerPrefs.SetInt("Unlocked3", 0);
        // sets current location to the location code that corrosponds to the last question asked
        currentLocation = (PlayerPrefs.GetInt("Question") / 3) + 1;
        // imputs current location into TestCompletion function
        TestCompletion(currentLocation);

        
    }

    void Update()
    {
        if (CheckCompletion(1) == true) { print(" Panda completed"); }
        if (CheckCompletion(2) == true) { print(" Leopard completed"); }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            PlayerPrefs.SetInt("Unlocked1", 0);
            PlayerPrefs.SetInt("Unlocked2", 0);
            PlayerPrefs.SetInt("Unlocked3", 0);
            print("All progress reset");
        }

    }
    // Tests whether the location after the current location has been completed. If it has not, sends sign to that location. If it has, tests the location after the next one, etc. If the current location is the last one on the list (number 3), it loops back to location 1.
    void TestCompletion(int location)
    {
        if ((location + 1) > 3) { TestCompletion(0); }
        else
        {
            if (CheckCompletion(location + 1) == false) { MoveSign(location + 1); } else { TestCompletion(location + 1); }
        }
    }

    // MoveSign moves the sign to the predetermined location
    void MoveSign(int locationCode)
    {
     
            Vector3[] xcoordinates = new[] { new Vector3(1000.0f, 0.0f, 0.0f), new Vector3(43.0f, -56.0f, 0.0f), new Vector3(-180.0f, -38.0f, 0.0f), new Vector3(57.0f, 47.0f, 0.0f) };
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