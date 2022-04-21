using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLanguageManager : MonoBehaviour
{
    [SerializeField]
    public Text winText;
    [SerializeField]
    public Text loseText;
    [SerializeField]
    public Text pauseText;

    // Start is called before the first frame update
    void Start()
    {
        if (LanguageClass.lg == 0)
        {
            loseText.text = " END GAME \n Try Again";
            winText.text = "!!! CONGRATULATION !!! \n You Won";
            pauseText.text = " PAUSE ";
        }
        else if(LanguageClass.lg == 1)
        {
            loseText.text = " FIN DE PARTIE \n Essayez encore";
            winText.text = "!!! FELICITATION !!! \n Vous avez gagné";
            pauseText.text = " PAUSE ";
        }
        else
        {
            loseText.text = " EINDSPEL \n Probeer het opnieuw";
            winText.text = "!!! GEFELICITEERD!!! \n Jij hebt gewonnen";
            pauseText.text = " PAUZE ";

        }
    }

    
}
