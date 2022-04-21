using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int pv;
    public int score;
    public GameObject[] tiles;
    public Animator blueAnim;
    public GameObject[] lives;
    public GameObject explodeAnim;
    public GameObject deadAnim;
    public Manager.Color color;
    public GameObject loseItem;
    public AudioSource playerCollision;
    void Start()
    {
        score = 0;
        pv = 4;
        color = Manager.Color.neutral;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Mob"))
        {

            //Manager.instance.player.transform.position = Manager.instance.tileMapGenerator.startPlayerPos;
            // Manager.instance.path.transform.position = Manager.instance.tileMapGenerator.startPlayerPos;
            //Manager.instance.player.state = 0;
            /*Manager.instance.fire.nb = 99999;
            Manager.instance.player.InstantiatePlayerPos(Manager.instance.tileMapGenerator.startPlayerPos.x, Manager.instance.tileMapGenerator.startPlayerPos.z);
            Manager.instance.tileMapGenerator.ClearTileColor();
            pv--;
            blueAnim.Play("Run", 0, 0.25f);*/
            // Destroy(other.gameObject);
            /*  Manager.instance.path.wayPoints = new Vector3[0];
              Manager.instance.path.oldWayPoints = new Vector3[0];
              Manager.instance.player.state = 0;

              Manager.instance.path.nb = 0;

              
              Debug.Log("live " + pv);
              */
            TouchedBehaviour();
        }

    }

    public void TouchedBehaviour()
    {
        pv--;
        score -= 5;
        playerCollision.Play();
        Manager.instance.scoreText.text = score.ToString();
        GameObject playerExplode = Instantiate(explodeAnim, transform.position, transform.rotation);
        playerExplode.GetComponent<ParticleSystem>().Play();
        Destroy(lives[pv].gameObject);
        if (pv > 0)
        {
            Manager.instance.fire.nb = 99999;
            Manager.instance.player.InstantiatePlayerPos(Manager.instance.tileMapGenerator.startPlayerPos.x, Manager.instance.tileMapGenerator.startPlayerPos.z);
            Manager.instance.tileMapGenerator.ClearTileColor();

            blueAnim.Play("Run", 0, 0.25f);
        }
        else
        {
            LoseAnimation();
        }
        
    }

    public void LoseAnimation()
    {
        loseItem.SetActive(true);
        GameObject playerDead = Instantiate(deadAnim, transform.position, transform.rotation);
        playerDead.GetComponent<ParticleSystem>().Play();
        DoDelayAction(3.5f);
    }

    void DoDelayAction(float delayTime)
    {
        StartCoroutine(DelayAction(delayTime));
    }

    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        loseItem.SetActive(false);
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);
    }



}
