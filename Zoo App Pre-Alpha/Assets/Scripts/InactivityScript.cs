﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InactivityScript : MonoBehaviour
{
    
    public CanvasGroup canvas;
    private bool faded;
    
    public bool bob;
    

   
    
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //touches = Input.touchCount;
        if(Input.touchCount > 0 && faded == true) {  FadeImage(false); faded = false; }
       
    }

   public void FadeImage(bool fadeAway)
    {

        // fade from opaque to transparent
        if (fadeAway)
        {


            StartCoroutine(wait());
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha


                canvas.alpha = i;
                // loop over 1 second backwards

            }
        }
        // fade from transparent to opaque
        else
        {

            // loop over 1 second
            for (float i = 0; i <= 1; i += 0.01f)
            {

                canvas.alpha = i;



            }
        }
    }
    
     IEnumerator wait() {
        yield return new WaitForSecondsRealtime(0.5f);

        faded = true;
            
                    
                   
                
                
            }
}

