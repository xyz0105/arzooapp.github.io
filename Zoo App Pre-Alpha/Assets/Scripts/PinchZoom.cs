using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinchZoom : MonoBehaviour
{
    // public GameObject textbox;
    public GameObject CameraFollower;
    float widthFactor;
    float heightFactor;
    bool firstTouch = false;
    bool firstDoubleTouch = false;
    Vector3 initialTouch;
    Vector3 currentTouch;
    Vector3 cameraStart;
    float distance;
    float initialDistance;
    float fovstart;

    private void Start()
    {

        print(Screen.width + " " + Screen.height);
        widthFactor = Screen.width / 5; heightFactor = Screen.height / 3;
    }
    private void Update()
    {

       // Text debugText = textbox.GetComponent<Text>();
        Vector3 cameraPosition = CameraFollower.transform.position;
        // Vector3 touch = Input.GetTouch(0).position;
        // text = "tap is at " + touch;

        if (Input.touchCount > 0)
        {


            float camerax = 2 * (Input.GetTouch(0).position.x / widthFactor) - 5; float cameray = 2 * (Input.GetTouch(0).position.y / heightFactor) - 3;
            if (firstTouch == false)
            {
                initialTouch = new Vector3(camerax, cameray, 0);
                firstTouch = true;
                cameraStart = CameraFollower.transform.position;

            }
            currentTouch = new Vector3(camerax, cameray, 0);

            CameraFollower.transform.position = Clamp(cameraStart + (Camera.main.fieldOfView / 41) * (initialTouch - currentTouch));

            // debugText.text = "camera is at " + camerax + ", " + cameray;

            if (Input.touchCount >= 2)
            {
                Vector2 touch0, touch1;
                
                touch0 = Input.GetTouch(0).position;
                touch1 = Input.GetTouch(1).position;
                distance = Vector2.Distance(touch0, touch1);
                if(firstDoubleTouch == false)
                {
                    initialDistance = distance;
                    firstDoubleTouch = true;
                    fovstart = Camera.main.fieldOfView;
                }
                Camera.main.fieldOfView = Mathf.Clamp(fovstart - ((distance - initialDistance) / 30), 6.0f, 41f);



            }
            else { firstDoubleTouch = false; }
        }
        else
        {
            // debugText.text = "No Touch";
            firstTouch = false;

        }






    }
    public Vector3 Clamp(Vector3 value)
    {
        value.x = Mathf.Clamp(value.x, -5f, 5f);
        value.y = Mathf.Clamp(value.y, -3f, 3f);
        value.z = Mathf.Clamp(value.z, 0, 0);
        return value;
    }
}
