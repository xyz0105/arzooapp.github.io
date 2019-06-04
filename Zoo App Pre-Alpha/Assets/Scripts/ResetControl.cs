using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetControl : MonoBehaviour
{
    //Initialize portraits
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

    //Initialize pop-up window
    public GameObject ResetConfirm;
    //public GameObject ConfirmParent;

    public void ConfirmReset()
    {
        //Store ResetConfirm pop-up window inside the initialized variable
        /*ConfirmParent = GameObject.Find("ConfirmParent");
        ResetConfirm = ConfirmParent.Find("ResetConfirm");*/

        //Open window
        ResetConfirm.SetActive(true);
    }

    public void ResetDenied()
    {
        //Store ResetConfirm pop-up window inside the initialized variable
        //ResetConfirm = GameObject.Find("ResetConfirm");

        //Close window
        ResetConfirm.SetActive(false);
    }

    public void ResetConfirmed()
    {
        //Store actual objects inside the initialized variable
        /*RhinoButton = GameObject.Find("RhinoButton");
        PandaButton = GameObject.Find("PandaButton");
        LeopardButton = GameObject.Find("LeopardButton");
        ResetConfirm = GameObject.Find("ResetConfirm");*/

        //Reset values
        PlayerPrefs.SetInt("Question", 0);
        PlayerPrefs.SetInt("Rights", 0);
        PlayerPrefs.SetInt("Wrongs", 0);
        PlayerPrefs.SetInt("ModelNumber", 0);
        PlayerPrefs.SetInt("Congratulated", 0);
        for (int i = 0; i < 34; i++)
        {
            PlayerPrefs.SetInt("Unlocked"+i, 0);
        }

        //Turn buttons off
        Macaw.SetActive(false);
        Crane.SetActive(false);
        Gibbon.SetActive(false);
        Hog.SetActive(false);
        Rhino.SetActive(false);
        Giraffe.SetActive(false);
        Meerkat.SetActive(false);
        Stork.SetActive(false);
        Cassowary.SetActive(false);
        Kangaroo.SetActive(false);
        Eland.SetActive(false);
        Bontebok.SetActive(false);
        Crowned.SetActive(false);
        Ostrich.SetActive(false);
        Springbok.SetActive(false);
        Zebra.SetActive(false);
        Tortoise.SetActive(false);
        Tiger.SetActive(false);
        RedTortoise.SetActive(false);
        Pudu.SetActive(false);
        Bear.SetActive(false);
        Guinea.SetActive(false);
        Hornbill.SetActive(false);
        Panda.SetActive(false);
        Leopard.SetActive(false);
        Lemur.SetActive(false);
        Duiker.SetActive(false);
        RedLemur.SetActive(false);
        Cougar.SetActive(false);
        Monkey.SetActive(false);
        Porcupine.SetActive(false);
        Tapir.SetActive(false);
        Screamer.SetActive(false);
        Flamingo.SetActive(false);


        //Close window
        ResetConfirm.SetActive(false);
    }
}
