using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelControl : MonoBehaviour
{
    //Initialize objects
    public GameObject Rhino;
    public GameObject Panda;
    public GameObject Leopard;

    // Start is called before the first frame update
    void Start()
    {
        //Store actual objects inside the initialized variable
        Rhino = GameObject.Find("Rhino");
        Panda = GameObject.Find("Panda");
        Leopard = GameObject.Find("Leopard");

        if (PlayerPrefs.GetInt("ModelNumber") == 1)
        {
            Rhino.SetActive(true);
            Panda.SetActive(false);
            Leopard.SetActive(false);
        }
        if (PlayerPrefs.GetInt("ModelNumber") == 2)
        {
            Rhino.SetActive(false);
            Panda.SetActive(true);
            Leopard.SetActive(false);
        }
        if (PlayerPrefs.GetInt("ModelNumber") == 3)
        {
            Rhino.SetActive(false);
            Panda.SetActive(false);
            Leopard.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
