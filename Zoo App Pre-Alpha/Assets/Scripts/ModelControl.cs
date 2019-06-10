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
        
    }

    public void ChooseProjection(int modelnumber)
    {
        PlayerPrefs.SetInt("ModelNumber", modelnumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
