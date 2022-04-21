using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class WinBehaviour : MonoBehaviour
{
    public GameObject winBlue;
    public GameObject winGreen;
    public GameObject winRed;
    public GameObject winScreen;
    public GameObject winObject;
    public GameObject winAnim;
    public AudioSource winSound;

    private void Start()
    {
        Text text = winScreen.GetComponentInChildren<Text>();

        if (LanguageClass.lg == 0)
        {
            text.text = "LEVEL COMPLETED";
        }
        else if (LanguageClass.lg == 1)
        {
            text.text = "NIVEAU VALIDE";
        }
        else
        {
            text.text = "NIVEAU VOLTOOID";
           
        }
    }
    public void WinBlueInitiate(float x, float z, GameObject parent)
    {

        Quaternion rotation = new Quaternion();
        rotation.Set(0, 180, 0, 1);
        GameObject win = Instantiate(winBlue, new Vector3(x, 0.2f, z), rotation);
        win.transform.parent = parent.transform;
        winObject = winBlue;

    }

    public void WinGreenInitiate(float x, float z, GameObject parent)
    {

        Quaternion rotation = new Quaternion();
        rotation.Set(0, 180, 0, 1);
        GameObject win = Instantiate(winGreen, new Vector3(x, 0.2f, z), rotation);
        win.transform.parent = parent.transform;
        winObject = winGreen;

    }

    public void WinRedInitiate(float x, float z, GameObject parent)
    {

        Quaternion rotation = new Quaternion();
        rotation.Set(0, 180, 0, 1);
        GameObject win = Instantiate(winRed, new Vector3(x, 0.2f, z), rotation);
        win.transform.parent = parent.transform;
        winObject = winRed;

    }

    public void IsWin()
    {
        Manager.instance.path.wayPoints = new Vector3[0];
        Manager.instance.path.oldWayPoints = new Vector3[0];
        Manager.instance.player.state = 3;
        
        winScreen.SetActive(true);
        winSound.Play();
        GameObject playerDead = Instantiate(winAnim, transform.position, transform.rotation);
        playerDead.GetComponent<ParticleSystem>().Play();
        Manager.instance.fire.nb = 99999;
        Manager.instance.player.state = 0;
        DoDelayAction(3.5f);

    }

    public void WinTuto()
    {
        winSound.Play();
        DoDelayAction2(2.5f);

    }


    void DoDelayAction(float delayTime)
    {
        StartCoroutine(DelayAction(delayTime));
    }

    void DoDelayAction2(float delayTime)
    {
        StartCoroutine(DelayAction2(delayTime));
    }

    IEnumerator DelayAction(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        winScreen.SetActive(false);
        Manager.instance.ChangeZOne();

    }

    IEnumerator DelayAction2(float delayTime)
    {
        yield return new WaitForSeconds(delayTime);
        SceneManager.LoadScene("StartMenu", LoadSceneMode.Single);

    }

}
