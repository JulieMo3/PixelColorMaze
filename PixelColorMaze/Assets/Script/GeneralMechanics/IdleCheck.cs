using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IdleCheck : MonoBehaviour
{
    float timeSinceLastClick = 0.0f;
    void Update()
    {
        timeSinceLastClick += Time.deltaTime;

        if (timeSinceLastClick > 20.0f)
        {
            SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
        }
    }

    public void CheckIfAnyInput()
    {
        timeSinceLastClick = 0.0f;
    }
}
