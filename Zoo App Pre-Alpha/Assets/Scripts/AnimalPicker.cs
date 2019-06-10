using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalPicker : MonoBehaviour
{
    public GameObject Panda;
    public GameObject Rhino;
    public GameObject Leopard;
   // public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
        //Store actual objects inside the initialized variable
        Rhino = GameObject.Find("Rhino");
        Panda = GameObject.Find("Panda");
        Leopard = GameObject.Find("Leopard");
       // Text debugText = textBox.GetComponent<Text>();

        if (PlayerPrefs.GetInt("ModelNumber") == 1)
        {
            Rhino.SetActive(true);
            Panda.SetActive(false);
            Leopard.SetActive(false);
            //debugText.text = "rhino";
        }
        if (PlayerPrefs.GetInt("ModelNumber") == 2)
        {
            Rhino.SetActive(false);
            Panda.SetActive(true);
            Leopard.SetActive(false);
           // debugText.text = "panda";
        }
        if (PlayerPrefs.GetInt("ModelNumber") == 3)
        {
            Rhino.SetActive(false);
            Panda.SetActive(false);
            Leopard.SetActive(true);
            //debugText.text = "Leopad";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
