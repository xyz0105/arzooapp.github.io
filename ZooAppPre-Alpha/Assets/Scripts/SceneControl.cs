using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void ChangeToScene(int changeTheScene)
    {
        SceneManager.LoadScene(changeTheScene);
    }
}