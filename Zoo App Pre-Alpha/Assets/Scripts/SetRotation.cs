using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRotation : MonoBehaviour
{
    public GameObject animalmodel;
    public Slider slider;
    public Slider sizeslider;
    // Start is called before the first frame update
    

    public void Rotate() { animalmodel.transform.localEulerAngles = new Vector3(270, slider.value, 0); }
    
    public void Size() { animalmodel.transform.localScale = new Vector3(sizeslider.value, sizeslider.value, sizeslider.value); }
}
