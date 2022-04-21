using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class TutoScreen : MonoBehaviour
{
    public GameObject EnContainer;
    public GameObject FrContainer;
    public GameObject NlContainer;
    public int nb = 0;
    public bool hasColor = false;
    GameObject tutoScreen;
    Transform screen;

    private void Awake()
    {
        LanguageClass.tutoChangeState = false;
       // LanguageClass.tuto = true;
        
    }
    void Start()
    {
       // sprite = this.gameObject.GetComponent<Image>().overrideSprite;
        if(LanguageClass.lg == 0)
        {
            EnContainer.SetActive(true);
            FrContainer.SetActive(false);
            NlContainer.SetActive(false);

            tutoScreen = EnContainer;

            
        }
        else if(LanguageClass.lg == 1)
        {
            EnContainer.SetActive(false);
            FrContainer.SetActive(true);
            NlContainer.SetActive(false);

            tutoScreen = FrContainer;
        }
        else
        {
            EnContainer.SetActive(false);
            FrContainer.SetActive(false);
            NlContainer.SetActive(true);

            tutoScreen = NlContainer;
        }

        screen = tutoScreen.transform.GetChild(nb);
        screen.gameObject.SetActive(true);
        nb++;
    }



    public void OnTutoRead(InputAction.CallbackContext context)
    {
        if (LanguageClass.tuto)
        {
            Debug.Log("in tuto");
            if (context.started)
            {
                Debug.Log("nb " + nb);

                if (nb < 5)
                {
                    if (nb != 0)
                    {
                        screen.gameObject.SetActive(false);
                        screen = tutoScreen.transform.GetChild(nb);
                        screen.gameObject.SetActive(true);
                        nb++;
                       
                       
                    }
                    else
                    {
                        screen = tutoScreen.transform.GetChild(nb);
                        screen.gameObject.SetActive(true);
                        nb++;
                    }
                }
                else
                {
                    Debug.Log("out of tuto");
                    //screen = tutoScreen.transform.GetChild(nb);
                    screen.gameObject.SetActive(false);
                    LanguageClass.tuto = false;
                    LanguageClass.tutoChangeState = true;
                }

                return; 
            }
       
        }
        
    }

    public void OnTutoReplay(InputAction.CallbackContext context)
    {
        nb = 0;
        LanguageClass.tuto = true;
        screen = tutoScreen.transform.GetChild(nb);
        screen.gameObject.SetActive(true);
        nb++;
    }

    public void PlayStatePath()
    {
        if (!hasColor)
        {
            screen.gameObject.SetActive(false);
            screen = tutoScreen.transform.GetChild(5);
            screen.gameObject.SetActive(true);
        }
       
       
    }

    public void PlayStateShoot()
    {
        if (!hasColor)
        {
            screen.gameObject.SetActive(false);
            screen = tutoScreen.transform.GetChild(6);
            screen.gameObject.SetActive(true);
        }
        
  
    }

    public void PlayStateColor()
    {
        hasColor = true;
        screen.gameObject.SetActive(false);
        screen = tutoScreen.transform.GetChild(7);
        screen.gameObject.SetActive(true);
    }

    public void PlayStateWin()
    {
        screen.gameObject.SetActive(false);
        screen = tutoScreen.transform.GetChild(9);
        screen.gameObject.SetActive(true);
        Manager.instance.winItem.WinTuto();
     
    }

    public void PlayStateNeutral()
    {
        if (!hasColor)
        {
            screen.gameObject.SetActive(false);
            screen = tutoScreen.transform.GetChild(8);
            screen.gameObject.SetActive(true);
        }
    }
}
