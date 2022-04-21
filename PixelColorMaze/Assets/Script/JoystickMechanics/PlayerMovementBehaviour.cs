using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMovementBehaviour : MonoBehaviour
{

    [Header ("input management")]
    [SerializeField]
    JoystickController inputManager;
    [SerializeField]
    public int state = 0;
    float inputX;
    float inputY;

    [Header("path selection tools")]
    
    public Vector2 move;
    [SerializeField]
    GameObject pathCube;
    public int speedCube;

    [Header("player general data")]
    private Camera cameraMain;
    [SerializeField]
    private LayerMask gridLayer = 6;
    TileInfo objPosition;
    public int playerXPos;
    public int playerZPos;
    public int nbLife;

    [Header("player fire state")]
    Vector3 rotation;
    public GameObject playerColor;

    [Header("player fire state")]
    public Text stateText;
    public bool tutoDone = false;

    

    void Start()
    {
        cameraMain = Camera.main;
        if (LanguageClass.lg == 0)
        {
            stateText.text = "Neutral Mode";
        }
        else if (LanguageClass.lg == 1)
        {
            stateText.text = "Mode Neutre";
        }
        else
        {
            stateText.text = "Neutrale Modus";

        }
    }
    public void SelectPath(InputAction.CallbackContext value)
    {
        /*if (state==1)
        {
            move = value.ReadValue<Vector2>();
        }*/
       
        move = value.ReadValue<Vector2>();
    }

    public void ChangeState(InputAction.CallbackContext value)
    {
      
        if (!LanguageClass.tuto )
        {
            Debug.Log("NOT in tuto");
            Debug.Log(state + " state");
            if (state != 2)
            {
                state++;
            }
            if (state == 1)
            {
                if (LanguageClass.tutoChangeState)
                {
                    Manager.instance.tuto.PlayStatePath();
                }
                
                if (LanguageClass.lg == 0)
                {
                    stateText.text = "Select Path";
                }
                else if (LanguageClass.lg == 1)
                {
                    stateText.text = "Selection chemin";
                }
                else
                {
                    stateText.text = "Selecteer pad";

                }
            }
            else if (state == 2)
            {
                if (LanguageClass.tutoChangeState)
                {
                    Manager.instance.tuto.PlayStateShoot();
                }
                if (LanguageClass.lg == 0)
                {
                    stateText.text = "Fire mode";
                }
                else if (LanguageClass.lg == 1)
                {
                    stateText.text = "Mode Tir";
                }
                else
                {
                    stateText.text = "Vuurmodus";

                }
            }
            else
            {
                
                if (LanguageClass.lg == 0)
                {
                    stateText.text = "Neutral Mode";
                }
                else if (LanguageClass.lg == 1)
                {
                    stateText.text = "Mode Neutre";
                }
                else
                {
                    stateText.text = "Neutrale Modus";

                }
            }
        }
       
        

    }


    public void BackToStart()
    {
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
    }


    public void InstantiatePlayerPos(float posX, float posZ)
    {
        this.transform.position = new Vector3(posX, 0.2f, posZ);
        Manager.instance.path.transform.position = new Vector3(posX, 0, posZ);
    }

    void LateUpdate()
    {
        if(nbLife <= 0)
        {
            Manager.instance.playerLife.LoseAnimation();
        }
        if (state==1)
        {
            
            inputX = move.x;
            inputY = move.y;
           // stateText.text = "Select Path";
            /*if (LanguageClass.lg == 0)
            {
                stateText.text = "Select Path";
            }
            else if (LanguageClass.lg == 1)
            {
                stateText.text = "Selection chemin";
            }
            else
            {
                stateText.text = "Selecteer pad";

            }*/
            if (Mathf.Abs(inputX) > Mathf.Abs(inputY))
            {
                inputY = 0;
            }
            else
            {
                inputX = 0;
            }
            Vector3 m = new Vector3(inputX, 0, inputY) * Time.deltaTime * speedCube;
            pathCube.transform.Translate(m,Space.Self);
         
        }
        else if(state == 2)
        {
          
            inputX = move.x;
            inputY = move.y;
            //stateText.text = "Fire";
            /*if (LanguageClass.lg == 0)
            {
                stateText.text = "Neutral Mode";
            }
            else if (LanguageClass.lg == 1)
            {
                stateText.text = "Mode Neutre";
            }
            else
            {
                stateText.text = "Neutrale Modus";

            }*/
            if (Mathf.Abs(inputX) > Mathf.Abs(inputY))
            {
                inputY = 0;
            }
            if (Mathf.Abs(inputX) > Mathf.Abs(inputY))
            {
                move.y = 0;
                rotation = new Vector3(move.x, 0, 0);

            }
            else
            {
              
                move.x = 0;
                rotation = new Vector3(0, 0, move.y);

            }
            
            transform.rotation = Quaternion.LookRotation(rotation);

        }
    }

}
