using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetRotation : MonoBehaviour
{
    
    public string animalname;
    public GameObject[] animalmodels;
    public GameObject animalmodel;
    public Slider slider;
    public Slider sizeslider;
    

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void Update()
    {
        animalmodels = GameObject.FindGameObjectsWithTag(animalname);
       /* foreach (GameObject animalmodel in animalmodels)
        {
            animalmodel.transform.localEulerAngles = new Vector3(270, slider.value, 0);
            animalmodel.transform.localScale = new Vector3(sizeslider.value, sizeslider.value, sizeslider.value);
            
        } */
    }

    public void Rotate() { foreach (GameObject animalmodel in animalmodels) { animalmodel.transform.localEulerAngles = new Vector3(270, slider.value, 0); } }
    
    public void Size() { foreach (GameObject animalmodel in animalmodels) { animalmodel.transform.localScale = new Vector3(sizeslider.value, sizeslider.value, sizeslider.value); } }
}
