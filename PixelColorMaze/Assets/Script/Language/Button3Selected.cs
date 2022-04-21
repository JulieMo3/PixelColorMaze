using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button3Selected : MonoBehaviour, ISelectHandler
{
    // public GameObject select;
    public LanguageSelection changePos;
    public void OnSelect(BaseEventData eventData)
    {
        //select.transform.position = new Vector3(select.transform.position.x, 0.353f, select.transform.position.z);
        changePos.MoveBottom();
        Debug.Log(this.gameObject.name + " was selected");
    }
}