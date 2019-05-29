using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinchZoom : MonoBehaviour {
    public GameObject textbox;
    private void Update()
    {


        if (Input.touchCount >= 2)
        {
            Vector2 touch0, touch1;
            float distance;
            touch0 = Input.GetTouch(0).position;
            touch1 = Input.GetTouch(1).position;
            distance = Vector2.Distance(touch0, touch1);

            string s = string.Format("{0:G}", distance);
            Text debugText = textbox.GetComponent<Text>();
            debugText.text = s;
            

            
                
        }
        else { Text debugText = textbox.GetComponent<Text>();
            debugText.text = "2 inputs not detected";
        }
        
    }
}
