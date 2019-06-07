using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GalleryControl : MonoBehaviour
{
    //Initialize animal portraits
    public GameObject Macaw;
    public GameObject Crane;
    public GameObject Gibbon;
    public GameObject Hog;
    public GameObject Rhino;
    public GameObject Giraffe;
    public GameObject Meerkat;
    public GameObject Stork;
    public GameObject Cassowary;
    public GameObject Kangaroo;
    public GameObject Eland;
    public GameObject Bontebok;
    public GameObject Crowned;
    public GameObject Ostrich;
    public GameObject Springbok;
    public GameObject Zebra;
    public GameObject Tortoise;
    public GameObject Tiger;
    public GameObject RedTortoise;
    public GameObject Pudu;
    public GameObject Bear;
    public GameObject Guinea;
    public GameObject Hornbill;
    public GameObject Panda;
    public GameObject Leopard;
    public GameObject Lemur;
    public GameObject Duiker;
    public GameObject RedLemur;
    public GameObject Cougar;
    public GameObject Monkey;
    public GameObject Porcupine;
    public GameObject Tapir;
    public GameObject Screamer;
    public GameObject Flamingo;

    //Initialize scrollbars
    public Scrollbar HScrollbar;
    public Scrollbar VScrollbar;

    //Initialize pop-up window
    public GameObject ResetConfirm;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("Unlocked24", 1);
        PlayerPrefs.SetInt("Unlocked25", 1);
        //Make sure ResetConfirm pop-up window starts out closed
        ResetConfirm.SetActive(false);

        //Set animal portraits to active or inactive based on completion
        if (PlayerPrefs.GetInt("Unlocked1") == 0)
        {
            Macaw.SetActive(false); //Macaw
        }
        else
        {
            Macaw.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked2") == 0)
        {
            Crane.SetActive(false);
        }
        else
        {
            Crane.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked3") == 0)
        {
            Gibbon.SetActive(false);
        }
        else
        {
            Gibbon.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked4") == 0)
        {
            Hog.SetActive(false);
        }
        else
        {
            Hog.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked5") == 0)
        {
            Rhino.SetActive(false);
        }
        else
        {
            Rhino.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked6") == 0)
        {
            Giraffe.SetActive(false);
        }
        else
        {
            Giraffe.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked7") == 0)
        {
            Meerkat.SetActive(false);
        }
        else
        {
            Meerkat.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked8") == 0)
        {
            Stork.SetActive(false);
        }
        else
        {
            Stork.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked9") == 0)
        {
            Cassowary.SetActive(false);
        }
        else
        {
            Cassowary.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked10") == 0)
        {
            Kangaroo.SetActive(false);
        }
        else
        {
            Kangaroo.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked11") == 0)
        {
            Eland.SetActive(false);
        }
        else
        {
            Eland.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked12") == 0)
        {
            Bontebok.SetActive(false);
        }
        else
        {
            Bontebok.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked13") == 0)
        {
            Crowned.SetActive(false);
        }
        else
        {
            Crowned.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked14") == 0)
        {
            Ostrich.SetActive(false);
        }
        else
        {
            Ostrich.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked15") == 0)
        {
            Springbok.SetActive(false);
        }
        else
        {
            Springbok.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked16") == 0)
        {
            Zebra.SetActive(false);
        }
        else
        {
            Zebra.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked17") == 0)
        {
            Tortoise.SetActive(false);
        }
        else
        {
            Tortoise.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked18") == 0)
        {
            Tiger.SetActive(false);
        }
        else
        {
            Tiger.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked19") == 0)
        {
            RedTortoise.SetActive(false);
        }
        else
        {
            RedTortoise.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked20") == 0)
        {
            Pudu.SetActive(false);
        }
        else
        {
            Pudu.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked21") == 0)
        {
            Bear.SetActive(false);
        }
        else
        {
            Bear.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked22") == 0)
        {
            Guinea.SetActive(false);
        }
        else
        {
            Guinea.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked23") == 0)
        {
            Hornbill.SetActive(false);
        }
        else
        {
            Hornbill.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked24") == 0)
        {
            Panda.SetActive(false);
        }
        else
        {
            Panda.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked25") == 0)
        {
            Leopard.SetActive(false);
        }
        else
        {
            Leopard.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked26") == 0)
        {
            Lemur.SetActive(false);
        }
        else
        {
            Lemur.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked27") == 0)
        {
            Duiker.SetActive(false);
        }
        else
        {
            Duiker.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked28") == 0)
        {
            RedLemur.SetActive(false);
        }
        else
        {
            RedLemur.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked29") == 0)
        {
            Cougar.SetActive(false);
        }
        else
        {
            Cougar.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked30") == 0)
        {
            Monkey.SetActive(false);
        }
        else
        {
            Monkey.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked31") == 0)
        {
            Porcupine.SetActive(false);
        }
        else
        {
            Porcupine.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked32") == 0)
        {
            Tapir.SetActive(false);
            Screamer.SetActive(false);
        }
        else
        {
            Tapir.SetActive(true);
            Screamer.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Unlocked33") == 0)
        {
            Flamingo.SetActive(false);
        }
        else
        {
            Flamingo.SetActive(true);
        }

        //Set the scrolling position to the center top
        VScrollbar.value = 1;
        HScrollbar.value = 0.5f;

        //Print all unlocked values to console
        for (int i = 0; i < 34; i++)
        {
            print("Unlocked" + i + ": " + PlayerPrefs.GetInt("Unlocked" + i));
        }
        StartCoroutine(pandaleopardpatch());
    }

    public void ScrollToTop()
    {
        VScrollbar.value = 1;
    }

    public void ScrollToBottom()
    {
        VScrollbar.value = 0;
    }

    IEnumerator pandaleopardpatch() { yield return new WaitForSeconds(0.5f);
        if (PlayerPrefs.GetInt("Unlocked24") == 1){ Panda.SetActive(true); }
        if (PlayerPrefs.GetInt("Unlocked24") == 1) { Leopard.SetActive(true); }
    }
}
