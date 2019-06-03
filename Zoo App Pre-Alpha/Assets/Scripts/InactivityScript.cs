using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InactivityScript : MonoBehaviour
{
    
    public CanvasGroup canvas;
    bool running;
    private int elapsed = 0;
    private bool timeElapsed;
    
    // Start is called before the first frame update
    void Start()
    {
        
        print("the script runs");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && running == false) { StartCoroutine(CountSeconds(5)); StartCoroutine(FadeImage(false)); running = true; } else { running = false; }
        if(timeElapsed == true) { StopCoroutine(CountSeconds(5)); timeElapsed = false; StartCoroutine(FadeImage(true)); }
        
    }

    IEnumerator FadeImage(bool fadeAway)
    {
        print("coroutine runs");
        // fade from opaque to transparent
        if (fadeAway)
        {
            
            // loop over 1 second backwards
            for (float i = 1; i >= 0; i -= Time.deltaTime)
            {
                // set color with i as alpha
                canvas.alpha = i;
                print("fading");
                yield return null;
            }
        }
        // fade from transparent to opaque
        else
        {
            // loop over 1 second
            for (float i = 0; i <= 1; i += Time.deltaTime)
            {
                print("unfading");
                canvas.alpha = i;
                yield return null;
            }
        }
    }
    IEnumerator CountSeconds(int seconds) { if (elapsed < seconds) { yield return new WaitForSeconds(1); elapsed += 1; } else { elapsed = 0; timeElapsed = true; } }
}
