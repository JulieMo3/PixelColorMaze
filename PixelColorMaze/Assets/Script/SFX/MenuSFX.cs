using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSFX : MonoBehaviour
{
    public AudioSource move;
    public AudioSource select;

    public void MoveSound()
    {
        move.Play();
    }

    public void SelectSound()
    {
        select.Play();
    }

    
}
