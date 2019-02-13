using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouAreHere : MonoBehaviour
{
    
    Vector3 PlayerLocation;
    public int locationCode = 2;
    int oldLocationCode = 1;
    /*
        Location Table:
        Location (Coordinates)

       1 Unseen New World (43, -56)
       2 Meercat (143, 16)
       3 Kangaroo (57, 47)
        */
    // Start is called before the first frame update
    void Start()
    { 
    }
      
    

    // Update is called once per frame
    void Update()
    {
        if (oldLocationCode != locationCode)
        {
            oldLocationCode = locationCode;
            Vector3[] xcoordinates = new[] {new Vector3(0.0f, 0.0f, 0.0f),new Vector3(43.0f, -56.0f, 0.0f), new Vector3(143.0f, 16.0f, 0.0f), new Vector3(57.0f, 47.0f, 0.0f) };
            PlayerLocation = xcoordinates[locationCode];
            print("Sign is at " + PlayerLocation);
            GetComponent<RectTransform>().localPosition = PlayerLocation;
        }
    }
}
