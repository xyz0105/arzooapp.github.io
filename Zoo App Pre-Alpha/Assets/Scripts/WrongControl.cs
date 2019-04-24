using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WrongControl : MonoBehaviour
{
    public void PlusOneWrong()
    {
        PlayerPrefs.SetInt("Wrongs", PlayerPrefs.GetInt("Wrongs") + 1);
    }
}
