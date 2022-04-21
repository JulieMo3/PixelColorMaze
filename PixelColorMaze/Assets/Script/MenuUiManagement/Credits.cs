using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public void BackToStart()
    {
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
    }
}
