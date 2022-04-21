using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public static Manager instance = null;
    public TileMapGenerator tileMapGenerator;
    public ArrayManager fieldArray;
    public PlayerMovementBehaviour player;
    public SelectPath path;
    public MobBehavior mobs;
    public Material selectColor;
    public Material secondSelectColor;
    public Material baseColor;
    public Material borderColor;
    public WinBehaviour winItem;
    public FireBehaviour fire;
    public PlayerLife playerLife;
    public TutoScreen tuto;
    public Text levelText;
    public Bullet bullet;
    public Text scoreText;
    public Color winColor;
    public int nbRedMob=0;
    public int nbGreenMob = 0;
    public int nbBlueMob = 0;
    public bool isLosable=false;
    public GameObject winScreen;

    bool pause= false;
    [SerializeField] GameObject pauseUI;
    public enum Color
    {
        red,
        blue,
        green,
        neutral
    }
    [SerializeField]
    int zone;


    private void Awake()
    {
        zone = 1;
        //levelText.text = "Level "+ zone;
        if (LanguageClass.lg == 0)
        {
            levelText.text = " Level " + zone;
        }
        else if (LanguageClass.lg == 1)
        {
            levelText.text = " Niveau " + zone;
        }
        else
        {
            levelText.text = " Peil " + zone;

        }
        if (instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
        
        ZoneSetUp();
    }

    void Update()
    {

    }


    public void ZoneSetUp()
    {
        if (zone == 1)
        {
            tileMapGenerator.gridHeight = 8;
            tileMapGenerator.gridWidth = 8;
            fieldArray.fieldManager = new int[8, 8] {
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 1, 0, 0, 0, 0, 6, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 0, 0, 2, 0, 0, 7},
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
            };
            tileMapGenerator.CreateQuadTileMap();

        }
        if (zone == 2)
        {
            tileMapGenerator.gridHeight = 8;
            tileMapGenerator.gridWidth = 8;
            fieldArray.fieldManager = new int[8, 8] {
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 0, 3, 0, 8, 0, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 1, 0, 0, 0, 3, 0, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
            };
            tileMapGenerator.CreateQuadTileMap();
            
        }
        if (zone == 3)
        {
            tileMapGenerator.gridHeight = 8;
            tileMapGenerator.gridWidth = 8;
            fieldArray.fieldManager = new int[8, 8] {
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 2, 0, 0, 3, 0, 7},
                                                       { 7, 1, 0, 0, 3, 6, 0, 7},
                                                       { 7, 0, 0, 0, 0, 0, 3, 7},
                                                       { 7, 0, 0, 0, 0, 0, 2, 7},
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
            };
            tileMapGenerator.CreateQuadTileMap();

        }
        if (zone == 4)
        {
            tileMapGenerator.gridHeight = 8;
            tileMapGenerator.gridWidth = 8;
            fieldArray.fieldManager = new int[8, 8] {
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
                                                       { 7, 0, 0, 0, 0, 4, 5, 7},
                                                       { 7, 0, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 4, 0, 0, 0, 0, 7},
                                                       { 7, 1, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 0, 0, 0, 0, 4, 7},
                                                       { 7, 2, 0, 0, 0, 0, 0, 7},
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
            };
            tileMapGenerator.CreateQuadTileMap();

        }
        if (zone == 5)
        {
            tileMapGenerator.gridHeight = 8;
            tileMapGenerator.gridWidth = 8;
            fieldArray.fieldManager = new int[8, 8] {
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
                                                       { 7, 0, 0, 0, 3, 0, 0, 7},
                                                       { 7, 0, 0, 0, 4, 0, 0, 7},
                                                       { 7, 0, 0, 0, 0, 0, 6, 7},
                                                       { 7, 1, 0, 0, 0, 0, 0, 7},
                                                       { 7, 0, 2, 0, 4, 0, 0, 7},
                                                       { 7, 0, 0, 0, 3, 0, 0, 7},
                                                       { 7, 7, 7, 7, 7, 7, 7, 7},
            };
            tileMapGenerator.CreateQuadTileMap();

        }
    }


    public void ChangeZOne()
    {
        zone++;
        if (LanguageClass.lg == 0)
        {
            levelText.text = " Level " + zone;
        }
        else if (LanguageClass.lg == 1)
        {
            levelText.text = " Niveau " + zone;
        }
        else
        {
            levelText.text = " Peil " + zone;

        }
        tileMapGenerator.ClearTab();
        ZoneSetUp();
        if (zone >= 6)
        {
            Text text = winScreen.GetComponentInChildren<Text>();

            if (LanguageClass.lg == 0)
            {
                text.text = "YOU WON \n you finished this prototype congrats!";
            }
            else if (LanguageClass.lg == 1)
            {
                text.text = "VICTOIRE \n vous avez fini le prototype, felicitation!";
            }
            else
            {
                text.text = "JIJ HEBT GEWONNEN \n je bent klaar met dit prototype gefeliciteerd!";

            }
            Winimation();
        }
    }

    public void Winimation()
    {
        winScreen.SetActive(true);
        //GameObject playerDead = Instantiate(deadAnim, transform.position, transform.rotation);
        //playerDead.GetComponent<ParticleSystem>().Play();
        DoDelayAction(5.2f);
    }

    void DoDelayAction(float delayTime)
    {
        StartCoroutine(DelayAction(delayTime));
    }

    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        winScreen.SetActive(false);
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
    }

    public void PauseGame()
    {
        if (!pause)
        {
            Time.timeScale = 0;
            pauseUI.SetActive(true);
            pause = true;
        }
        else
        {
            Time.timeScale = 1;
            pauseUI.SetActive(false);
            pause = false;
        }
        
    }

  
}


