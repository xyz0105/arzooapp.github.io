using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScannedTarget : MonoBehaviour
{

    public int ScannedAnimal;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void AnimalScanned(int animal)
    { ScannedAnimal = animal; }
    
}
