using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBehaviour : MonoBehaviour
{
    Vector3[] pathSelected;
    [SerializeField]
    int moveSpeed;
    int nbShoot = 0;
    public int nb = 0;
    int nbCol = 0;
    bool shooting;
    public GameObject bullet;
    public GameObject bulletSpawnPoint;
    private Transform bulletSpawned;
    public AudioSource explosionSound;
    


    void Update()
    {

        if (Manager.instance.player.state == 2)
        {
            pathSelected = Manager.instance.path.GetPath();

            if (nb < pathSelected.Length)
            {
                if (Vector3.Distance(transform.position, pathSelected[nb]) > 0.05f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, pathSelected[nb], Time.deltaTime * moveSpeed);
                }
                else
                {

                    nb++;
                }
            }
            else
            {
                
                nb = 0;
                if (LanguageClass.lg == 0)
                {
                    Manager.instance.player.stateText.text = "Neutral Mode";
                }
                else if (LanguageClass.lg == 1)
                {
                    Manager.instance.player.stateText.text = "Mode Neutre";
                }
                else
                {
                    Manager.instance.player.stateText.text = "Neutrale Modus";

                }
                if (LanguageClass.tutoChangeState)
                {
                    Manager.instance.tuto.PlayStateNeutral();
                }
                Manager.instance.path.wayPoints = new Vector3[0];
                Manager.instance.path.oldWayPoints = new Vector3[0];
                Manager.instance.player.state = 0;
            }

            if (shooting)
            {
                Instantiate(bullet, bulletSpawnPoint.transform.position, bulletSpawnPoint.transform.rotation);
                shooting = false;

            }


        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (Manager.instance.player.state == 2)
        {
            if (other.GetComponent<MeshRenderer>().material.color == Manager.instance.secondSelectColor.color)
            {

                other.GetComponent<MeshRenderer>().material = Manager.instance.selectColor;
                other.gameObject.tag = "Tile";
            }
            else if (other.GetComponent<MeshRenderer>().material.color == Manager.instance.selectColor.color)
            {
                other.GetComponent<MeshRenderer>().material = Manager.instance.baseColor;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Mob"))
        {
            if (nbCol == 2) nbCol = -1;
            if (nbCol == 1)
            {
                Manager.instance.player.nbLife--;
                Debug.Log(Manager.instance.player.nbLife);
            }
            nbCol++;
        }
        else if (other.gameObject.CompareTag("Win"))
        {
            Debug.Log("win");
            if (Manager.instance.playerLife.color == other.transform.GetComponent<ColorMob>().colorMob)
            {
                if (LanguageClass.tutoChangeState)
                {
                    Manager.instance.tuto.PlayStateWin();
                }
                else
                {
                    Manager.instance.winItem.IsWin();
                }
                
            }
            else
            {
                Debug.Log("not good component");
            }

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (Manager.instance.player.state == 2)
        {
            if (nb == pathSelected.Length - 1) other.GetComponent<MeshRenderer>().material = Manager.instance.baseColor;
        }
    }

    public void Shoot()
    {
        if (Manager.instance.player.state == 2)
        {

            if (nbShoot == 2) nbShoot = -1;
            if (nbShoot == 1) shooting = true;
            
            nbShoot++;
          
        }

    }

    public void ShootSound(AudioSource sound)
    {
        sound.Play();
    }

    public void ExplosionSound()
    {
        explosionSound.Play();
    }

}
