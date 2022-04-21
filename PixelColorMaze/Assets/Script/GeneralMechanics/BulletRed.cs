using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRed : MonoBehaviour
{
    [Header("Variables")]
    public float Speed;

    public float maxDistance;

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

        if (other.gameObject.CompareTag("Player"))
        {
            //PV --
            // Destroy(other.gameObject);
            Manager.instance.playerLife.TouchedBehaviour();
        }

    }
}
