using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    public MenuSFX sound;
    public GameObject start;
    public GameObject credits;
    public GameObject language;
    public GameObject tuto;
    public GameObject player;
    public GameObject arcadeStartFR;
    public GameObject arcadeCreditsFR;
    public GameObject arcadeSettingsFR;
    public GameObject arcadeStartEN;
    public GameObject arcadeCreditsEN;
    public GameObject arcadeSettingsEN;
    public GameObject arcadeStartNL;
    public GameObject arcadeCreditsNL;
    public GameObject arcadeSettingsNL;
    public GameObject arcadeTutoEN;
    public GameObject arcadeTutoFR;
    public GameObject arcadeTutoNL;
    [SerializeField] public LevelLoader levelLoad;
    int nb ;
    float posBottom;
    float posTop;
    button typeButton;
    enum button
    {
        Start, Credit, language, Tuto
    }
    private void Awake()
    {
        LanguageClass.tuto = false;
        posBottom = player.transform.position.y;
        posTop = posBottom + 0.05f;
        nb = 0;
        typeButton = button.Start;
        arcadeCreditsEN.SetActive(false);
        arcadeSettingsEN.SetActive(false);
        arcadeStartEN.SetActive(false);
        arcadeCreditsFR.SetActive(false);
        arcadeSettingsFR.SetActive(false);
        arcadeStartFR.SetActive(false);
        arcadeCreditsNL.SetActive(false);
        arcadeSettingsNL.SetActive(false);
        arcadeStartNL.SetActive(false);
        arcadeTutoEN.SetActive(false);
        arcadeTutoFR.SetActive(false);
        arcadeTutoNL.SetActive(false);

        if (LanguageClass.lg == 0)
        {
            arcadeCreditsEN.SetActive(false);
            arcadeSettingsEN.SetActive(false);
            arcadeStartEN.SetActive(true);
            arcadeTutoEN.SetActive(false);
        }
        else if (LanguageClass.lg == 1)
        {
            arcadeCreditsFR.SetActive(false);
            arcadeSettingsFR.SetActive(false);
            arcadeStartFR.SetActive(true);
            arcadeTutoFR.SetActive(false);
        }
        else
        {
            arcadeCreditsNL.SetActive(false);
            arcadeSettingsNL.SetActive(false);
            arcadeStartNL.SetActive(true);
            arcadeTutoNL.SetActive(false);
        }


    }

    public void OnMoveLeft(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            switch (typeButton)
            {
                case button.Start:
                    player.transform.position = new Vector3(start.transform.position.x, posBottom, start.transform.position.z);
                    typeButton = button.Start;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(true);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(true);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(true);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.Credit:
                    player.transform.position = new Vector3(start.transform.position.x, posBottom, start.transform.position.z);
                    typeButton = button.Start;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(true);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(true);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(true);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.language:
                    player.transform.position = new Vector3(language.transform.position.x, posTop, language.transform.position.z);
                    typeButton = button.language;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(true);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(true);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(true);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.Tuto:
                    player.transform.position = new Vector3(language.transform.position.x, posTop, language.transform.position.z);
                    typeButton = button.language;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(true);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(true);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(true);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;

            }
        }

    }

    public void OnMoveRight(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            switch (typeButton)
            {
                case button.Start:
                    player.transform.position = new Vector3(credits.transform.position.x, posBottom, credits.transform.position.z);
                    typeButton = button.Credit;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(true);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(true);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(true);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.Credit:
                    player.transform.position = new Vector3(credits.transform.position.x, posBottom, credits.transform.position.z);
                    typeButton = button.Credit;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(true);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(true);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(true);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.language:
                    player.transform.position = new Vector3(tuto.transform.position.x, posTop, tuto.transform.position.z);
                    typeButton = button.Tuto;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(true);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(true);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoFR.SetActive(true);
                    }
                    sound.MoveSound();
                    break;
                case button.Tuto:
                    player.transform.position = new Vector3(tuto.transform.position.x, posTop, tuto.transform.position.z);
                    typeButton = button.Tuto;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(true);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(true);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoFR.SetActive(true);
                    }
                    sound.MoveSound();
                    break;

            }
        }

    }
    public void OnMoveUp(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            switch (typeButton)
            {
                case button.Start:
                    player.transform.position = new Vector3(language.transform.position.x, posTop, language.transform.position.z);
                    typeButton = button.language;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(true);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(true);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(true);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.Credit:
                    player.transform.position = new Vector3(tuto.transform.position.x, posTop, tuto.transform.position.z);
                    typeButton = button.Tuto;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(true);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(true);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoFR.SetActive(true);
                    }
                    sound.MoveSound();
                    break;
                case button.language:
                    player.transform.position = new Vector3(language.transform.position.x, posTop, language.transform.position.z);
                    typeButton = button.language;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(true);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(true);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(true);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.Tuto:
                    player.transform.position = new Vector3(tuto.transform.position.x, posTop, tuto.transform.position.z);
                    typeButton = button.Tuto;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(true);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(true);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoFR.SetActive(true);
                    }
                    sound.MoveSound();
                    break;

            }
        }

    }
    public void OnMoveDown(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            switch (typeButton)
            {
                case button.Start:
                    player.transform.position = new Vector3(start.transform.position.x, posBottom, start.transform.position.z);
                    typeButton = button.Start;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(true);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(true);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(true);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.Credit:
                    player.transform.position = new Vector3(credits.transform.position.x, posBottom, credits.transform.position.z);
                    typeButton = button.Credit;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(true);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(true);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(true);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.language:
                    player.transform.position = new Vector3(start.transform.position.x, posBottom, start.transform.position.z);
                    typeButton = button.Start;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(false);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(true);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(false);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(true);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(false);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(true);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;
                case button.Tuto:
                    player.transform.position = new Vector3(credits.transform.position.x, posBottom, credits.transform.position.z);
                    typeButton = button.Credit;
                    if (LanguageClass.lg == 0)
                    {
                        arcadeCreditsEN.SetActive(true);
                        arcadeSettingsEN.SetActive(false);
                        arcadeStartEN.SetActive(false);
                        arcadeTutoEN.SetActive(false);
                    }
                    else if (LanguageClass.lg == 1)
                    {
                        arcadeCreditsFR.SetActive(true);
                        arcadeSettingsFR.SetActive(false);
                        arcadeStartFR.SetActive(false);
                        arcadeTutoFR.SetActive(false);
                    }
                    else
                    {
                        arcadeCreditsNL.SetActive(true);
                        arcadeSettingsNL.SetActive(false);
                        arcadeStartNL.SetActive(false);
                        arcadeTutoNL.SetActive(false);
                    }
                    sound.MoveSound();
                    break;

            }
        }

    }
    /*public void MoveLeft()
    {
        player.transform.position = new Vector3(start.transform.position.x, posBottom, start.transform.position.z);
        typeButton = button.Start;
        if (LanguageClass.lg == 0)
        {
            arcadeCreditsEN.SetActive(false);
            arcadeSettingsEN.SetActive(false);
            arcadeStartEN.SetActive(true);
        }
        else if (LanguageClass.lg == 1)
        {
            arcadeCreditsFR.SetActive(false);
            arcadeSettingsFR.SetActive(false);
            arcadeStartFR.SetActive(true);
        }
        else
        {
            arcadeCreditsNL.SetActive(false);
            arcadeSettingsNL.SetActive(false);
            arcadeStartNL.SetActive(true);
        }
        sound.MoveSound();


    }

    public void MoveRight()
    {
        player.transform.position = new Vector3(credits.transform.position.x, posBottom, credits.transform.position.z);
        typeButton = button.Credit;
        if (LanguageClass.lg == 0)
        {
            arcadeCreditsEN.SetActive(true);
            arcadeSettingsEN.SetActive(false);
            arcadeStartEN.SetActive(false);
        }
        else if (LanguageClass.lg == 1)
        {
            arcadeCreditsFR.SetActive(true);
            arcadeSettingsFR.SetActive(false);
            arcadeStartFR.SetActive(false);
        }
        else
        {
            arcadeCreditsNL.SetActive(true);
            arcadeSettingsNL.SetActive(false);
            arcadeStartNL.SetActive(false);
        }
        sound.MoveSound();
    }

    public void MoveDown()
    {
        player.transform.position = new Vector3(start.transform.position.x, posBottom, start.transform.position.z);
        typeButton = button.Start;
        if (LanguageClass.lg == 0)
        {
            arcadeCreditsEN.SetActive(false);
            arcadeSettingsEN.SetActive(false);
            arcadeStartEN.SetActive(true);
        }
        else if (LanguageClass.lg == 1)
        {
            arcadeCreditsFR.SetActive(false);
            arcadeSettingsFR.SetActive(false);
            arcadeStartFR.SetActive(true);
        }
        else
        {
            arcadeCreditsNL.SetActive(false);
            arcadeSettingsNL.SetActive(false);
            arcadeStartNL.SetActive(true);
        }
        sound.MoveSound();
    }

    public void MoveTop()
    {
        player.transform.position = new Vector3(language.transform.position.x, posTop, language.transform.position.z);
        typeButton = button.language;
        if (LanguageClass.lg == 0)
        {
            arcadeCreditsEN.SetActive(false);
            arcadeSettingsEN.SetActive(true);
            arcadeStartEN.SetActive(false);
        }
        else if (LanguageClass.lg == 1)
        {
            arcadeCreditsFR.SetActive(false);
            arcadeSettingsFR.SetActive(true);
            arcadeStartFR.SetActive(false);
        }
        else
        {
            arcadeCreditsNL.SetActive(false);
            arcadeSettingsNL.SetActive(true);
            arcadeStartNL.SetActive(false);
        }
        sound.MoveSound();
    }*/

    public void SelectButton()
    {
        sound.MoveSound();
        if (typeButton == button.Start)
        {
            levelLoad.loadScreen.SetActive(true);
            LanguageClass.tuto = false;
            levelLoad.LoadLevel("JoystickTest");
            //SceneManager.LoadScene("JoystickTest", LoadSceneMode.Single);
        }
        else if (typeButton == button.Credit)
        {
            //levelLoad.LoadLevel("Credits");
            SceneManager.LoadScene("Credits", LoadSceneMode.Single);
        }
        else if (typeButton == button.language)
        {
            //levelLoad.LoadLevel("Language");
            SceneManager.LoadScene("Language", LoadSceneMode.Single);
        }
        else if (typeButton == button.Tuto)
        {
            //levelLoad.LoadLevel("Language");
            levelLoad.loadScreen.SetActive(true);
            LanguageClass.tuto = true;
            SceneManager.LoadScene("Tuto", LoadSceneMode.Single);
        }
    }


   /* private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Start"))
        {
            typeButton = button.Start;
        }
        else if (other.gameObject.CompareTag("Credits"))
        {
            typeButton = button.Credit;
        }
        else
        {
            typeButton = button.language;
        }
        Debug.Log(typeButton);
    }*/

    

}
