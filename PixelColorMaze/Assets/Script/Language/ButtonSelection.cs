using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonSelection : MonoBehaviour, ISelectHandler
{
  //  public GameObject select;
    public LanguageSelection changePos;
    public void OnSelect(BaseEventData eventData)
    {
        //select.transform.position = new Vector3(select.transform.localPosition.x, -0.053f, select.transform.localPosition.z);
        changePos.MoveTop();
        Debug.Log(this.gameObject.name + " was selected");
    }
}
