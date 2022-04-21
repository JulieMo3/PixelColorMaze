using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LanguageSelection : MonoBehaviour
{
    int lang = -1;

    public void Validate()
    {
        LanguageClass.lg = lang;
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
    }
    public void MoveTop()
    {
        lang = 1;
        Debug.Log("move top");
        this.transform.position = new Vector3(this.transform.position.x, 0.352f, this.transform.position.z);
    }

    public void MoveMiddle()
    {
        lang = 0;
        Debug.Log("move middle");
        this.transform.position = new Vector3(this.transform.position.x, 0.162f, this.transform.position.z);
    }

    public void MoveBottom()
    {
        lang = 2;
        Debug.Log("move bottom");
        this.transform.position = new Vector3(this.transform.position.x, -0.053f, this.transform.position.z);
    }

}
