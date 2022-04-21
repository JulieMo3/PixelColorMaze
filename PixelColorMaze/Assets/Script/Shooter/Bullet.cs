using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet : MonoBehaviour
{
    [Header("Variables")]
    public float Speed;
    public AudioSource fireSound;
    
    public float maxDistance;


    //particles
    public GameObject aura;
    public GameObject explosionMob;
    

    private void Start()
    {
        Manager.instance.fire.ShootSound(fireSound);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
        maxDistance += 1 * Time.deltaTime;

        if (maxDistance >= 2)
            Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Mob"))
        {
           
            //Debug.Log("isLosable" + isLosable);
            if (Manager.instance.isLosable)
            {
                Debug.Log("it is lose");
                Manager.instance.playerLife.LoseAnimation();
            }
            Manager.instance.playerLife.score += 20;
            Manager.instance.scoreText.text = Manager.instance.playerLife.score.ToString();
           // StartCoroutine(startAndStopParticleSystem());
            Manager.instance.player.GetComponent<MeshRenderer>().material = other.GetComponent<MeshRenderer>().material;
            Manager.instance.player.playerColor.GetComponent<SkinnedMeshRenderer>().material = other.GetComponent<MeshRenderer>().material;
            Manager.instance.playerLife.color = other.transform.GetComponent<ColorMob>().colorMob;
            if (other.transform.GetComponent<ColorMob>().colorMob == Manager.Color.blue)
            {
                Manager.instance.nbBlueMob--;
                if ((other.transform.GetComponent<ColorMob>().colorMob == Manager.instance.winColor) && (Manager.instance.nbBlueMob == 0))
                {
                    Manager.instance.isLosable = true;
                }
                if (LanguageClass.tutoChangeState)
                {
                    Manager.instance.tuto.PlayStateColor();
                }
            }
            else if (other.transform.GetComponent<ColorMob>().colorMob == Manager.Color.green)
            {
                Manager.instance.nbGreenMob--;
                if ((other.transform.GetComponent<ColorMob>().colorMob == Manager.instance.winColor) && (Manager.instance.nbGreenMob == 0))
                {
                    Manager.instance.isLosable = true;
                }
            }
            else if (other.transform.GetComponent<ColorMob>().colorMob == Manager.Color.red)
            {
                Manager.instance.nbRedMob--;
                if ((other.transform.GetComponent<ColorMob>().colorMob == Manager.instance.winColor) && (Manager.instance.nbRedMob == 0))
                {
                    Manager.instance.isLosable = true;
                    Debug.Log("is losable " + Manager.instance.isLosable);
                }
            }
            Explode(other.gameObject);
            Manager.instance.fire.ExplosionSound();
            
            Destroy(other.gameObject);
            Destroy(this.gameObject);

        }
       
    }

    void Explode(GameObject mob)
    {
        //Instantiate(mob, mob.transform.position, mob.transform.rotation);
        /*GameObject positifPlayer = Instantiate(touchedPositif, Manager.instance.playerLife.gameObject.transform.position, Quaternion.identity);
        positifPlayer.GetComponent<ParticleSystem>().Play();*/

        GameObject mobExplode = Instantiate(explosionMob,mob.transform.position , mob.transform.rotation);
        mobExplode.GetComponent<ParticleSystem>().Play();

    }


  /*  IEnumerator startAndStopParticleSystem()
    {
        GameObject positifPlayer = Instantiate(touchedPositif, Manager.instance.playerLife.gameObject.transform.position, Quaternion.identity);
        positifPlayer.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(3);
       positifPlayer.GetComponent<ParticleSystem>().Stop();
        yield return new WaitForSeconds(0);
       }*/
}
