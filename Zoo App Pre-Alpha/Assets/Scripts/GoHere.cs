using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoHere : MonoBehaviour
{

    Vector3 PlayerLocation;
    public int location = 2;
    public int currentLocation;
    public int locationLimit;


    /*
        Location Table:
       Integer "location code" for location, name of location, and Coordinates

       0 Offscreen
       1 Hyacinth Macaw (5.26f, -1.27f, -0.0001f)
       2 Stanley Crane (5.26f, -0.82f, -0.0001f)
       3 White Cheeked Gibbon (3.45f, -0.47f, -0.0001f)
       4 Red River Hog (2.81f, 2.01f, -0.0001f)
       5 Southern White Rhino (2.04f, 2.5f, -0.0001f)
       6 Giraffe (0.56f, 3.2f, -0.0001f)
       7 Meerkat (2.16f, -0.13f, -0.0001f)
       8 Saddle-Billed Stork (2.217f, -0.744f, -0.0001f)
       9 Cassowary (0.439f, -0.156f, -0.0001f)
       10 Kangaroo (1.131f, 0.383f, -0.0001f)
       11 Eland (0.42f, 1.629f, -0.0001f)
       12 Bontebok (0.42f, 1.629f, -0.0001f)
       13 Gray Crowned Crane (0.42f, 1.629f, -0.0001f)
       14 Otrich (0.42f, 1.629f, -0.0001f)
       15 Springbok (0.42f, 1.629f, -0.0001f)
       16 Zebra (0.42f, 1.629f, -0.0001f)
       17 Sulcata Tortoise (-0.298f, 2.036f, -0.0001f)
       18 Sumatran Tiger (-1.816f, 2.571f, -0.0001f)
       19 Red-Footed Tortoise (-0.535f, 1.026f, -0.0001f)
       20 Southern Pudu (-0.688f, 1.17f, -0.0001f)
       21 Andean Bear (-1.495f, 1.107f, -0.0001f)
       22 Guinea Pig (-1.014f, 0.35f, -0.0001f)
       23 Rhino Hornbill (-1.837f, -0.266f, -0.0001f)
       24 Red Panda (-2.598f, -0.958f, -0.0001f)
       25 Clouded Leopard (-2.385f, -1.04f, -0.0001f)
       26 Ring-Tailed Lemur (-2.61f, -0.052f, -0.0001f)
       27 Yellow-Backed Duiker (-3.51f, -0.926, -0.0001f)
       28 Red-Ruffed Lemur (-3.152f, 0.367f, -0.0001f)
       29 Cougar (-4.451f, 0.572f, -0.0001f)
       30 Mexican Spider Monkey (-3.869f, -1.614f, -0.0001f)
       31 Cape Porcupine (-2.51f, -1.696f, -0.0001f)
       32 Baird's Tapir/Crested Screamer (-1.256f, -2.209f, -0.0001f)
       33 Caribbean Flamingo (-0.274f, -0.097f, -0.0001f)

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
     
            Vector3[] xcoordinates = new[] {
                new Vector3(1000.0f, 0.0f, -1.0f), 
                new Vector3
               (5.26f, -1.27f, -0.0001f),
                new Vector3
(5.26f, -0.82f, -0.0001f),
                new Vector3
(3.45f, -0.47f, -0.0001f),
                new Vector3
(2.81f, 2.01f, -0.0001f),
                new Vector3
(2.04f, 2.5f, -0.0001f),
                new Vector3
(0.56f, 3.2f, -0.0001f),
                new Vector3
(2.16f, -0.13f, -0.0001f),
                new Vector3
(2.217f, -0.744f, -0.0001f),
                new Vector3
(0.439f, -0.156f, -0.0001f),
                new Vector3
(1.131f, 0.383f, -0.0001f),
                new Vector3
(0.42f, 1.629f, -0.0001f),
                new Vector3
(0.42f, 1.629f, -0.0001f),
                new Vector3
(0.42f, 1.629f, -0.0001f),
                new Vector3
(0.42f, 1.629f, -0.0001f),
                new Vector3
(0.42f, 1.629f, -0.0001f),
                new Vector3
(0.42f, 1.629f, -0.0001f),
                new Vector3
(-0.298f, 2.036f, -0.0001f),
                new Vector3
(-1.816f, 2.571f, -0.0001f),
                new Vector3
(-0.535f, 1.026f, -0.0001f),
                new Vector3
(-0.688f, 1.17f, -0.0001f),
                new Vector3
(-1.495f, 1.107f, -0.0001f),
                new Vector3
(-1.014f, 0.35f, -0.0001f),
                new Vector3
(-1.837f, -0.266f, -0.0001f),
                new Vector3
(-2.598f, -0.958f, -0.0001f),
                new Vector3
(-2.385f, -1.04f, -0.0001f),
                new Vector3
(-2.61f, -0.052f, -0.0001f),
                new Vector3
(-3.51f, -0.926f, -0.0001f),
                new Vector3
(-3.152f, 0.367f, -0.0001f),
                new Vector3
(-4.451f, 0.572f, -0.0001f),
                new Vector3
(-3.869f, -1.614f, -0.0001f),
                new Vector3
(-2.51f, -1.696f, -0.0001f),
                new Vector3
(-1.256f, -2.209f, -0.0001f),
                new Vector3
(-0.274f, -0.097f, -0.0001f),
                
                };
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