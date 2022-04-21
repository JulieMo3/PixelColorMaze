using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobBehavior : MonoBehaviour
{
    public GameObject mobBlue;
    public GameObject mobGreen;
    public GameObject mobRed;


    public void mobBlueInitiate(float x, float z,GameObject parent)
    {

        Quaternion rotation = new Quaternion();
        rotation.Set(0, 180, 0, 1);
        GameObject blue = Instantiate(mobBlue, new Vector3(x, 0, z), rotation);
        blue.transform.parent = parent.transform;

    }

    public void mobGreenInitiate(float x, float z, GameObject parent)
    {

        Quaternion rotation = new Quaternion();
        rotation.Set(0, 180, 0, 1);
        GameObject green = Instantiate(mobGreen, new Vector3(x, 0, z), rotation);
        green.transform.parent = parent.transform;
    }

    public void mobRedInitiate(float x, float z, GameObject parent)
    {

        Quaternion rotation = new Quaternion();
        rotation.Set(0, 180, 0, 1);
        GameObject red = Instantiate(mobRed, new Vector3(x, 0.3f, z), rotation);
        red.transform.parent = parent.transform;
    }




}
