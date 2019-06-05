using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRotation : MonoBehaviour
{
    
    public string animalname;
    public GameObject animalmodel;
    public Slider slider;
    public Slider sizeslider;

    // Start is called before the first frame update
    private void Start()
    {
        animalmodel = GameObject.Find(animalname);
        print(animalname);
    }

    private void Update()
    {
        animalmodel = GameObject.Find(animalname);
        animalmodel.transform.localEulerAngles = new Vector3(270, slider.value, 0);
        animalmodel.transform.localScale = new Vector3(sizeslider.value, sizeslider.value, sizeslider.value);
    }

    public void Rotate() { animalmodel.transform.localEulerAngles = new Vector3(270, slider.value, 0); }
    
    public void Size() { animalmodel.transform.localScale = new Vector3(sizeslider.value, sizeslider.value, sizeslider.value); }
}
