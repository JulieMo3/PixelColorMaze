using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floater : MonoBehaviour
{
    [SerializeField] public float degreesPerSecond = 15.0f;
    [SerializeField] public float amplitude = 0.5f;
    [SerializeField] public float frequency = 1f;
    public float turn = 0;
    [SerializeField] public float frequencyturn = 15;
    bool changeDir = false;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();


    void Start()
    {

        posOffset = transform.position;
    }


    void Update()
    {

        // Spin object around Y-Axis
        //turn = Time.deltaTime * degreesPerSecond;
        float angle = Mathf.Sin(Time.unscaledTime) * frequencyturn; //tweak this to change frequency

        transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
        //transform.Rotate(new Vector3(0f, turn, 0f), Space.World);

        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.unscaledDeltaTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}
