using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class GreenMob : MonoBehaviour
{
    int time;
    Sequence sequence;
    bool forward = true;
    // Start is called before the first frame update
    void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        time++;
        if (time % 100 == 0)
        {
            float z = transform.position.z + 0.55f;
            if (z > 3.5) forward = false;
            if (z < 1.5) forward = true;
            if (forward)
            {
                // sequence.Insert(0.3f, transform.DOMoveX(this.transform.position.x+1.05f, 1f)).SetEase(Ease.OutCubic);
                sequence.Insert(0f, transform.DOLookAt(new Vector3(this.transform.position.x , transform.position.y, transform.position.z + 1.05f), 0.2f, AxisConstraint.None, Vector3.up));
                sequence.Insert(2.3f, transform.DOJump(new Vector3(this.transform.position.x , transform.position.y, transform.position.z + 0.55f), 0.3f, 1, 0.7f).SetEase(Ease.OutCubic));

                DOTween.Play(sequence);
                //. this.transform.position = new Vector3(this.transform.position.x , this.transform.position.y, this.transform.position.z+1);
                time++;
            }
            else
            {
                // sequence.Insert(0.3f, transform.DOMoveX(this.transform.position.x+1.05f, 1f)).SetEase(Ease.OutCubic);
                sequence.Insert(0f, transform.DOLookAt(new Vector3(this.transform.position.x , transform.position.y, transform.position.z - 1.05f), 0.2f, AxisConstraint.None, Vector3.up));
                sequence.Insert(2.3f, transform.DOJump(new Vector3(this.transform.position.x, transform.position.y, transform.position.z - 0.55f), 0.3f, 1, 0.7f).SetEase(Ease.OutCubic));

                DOTween.Play(sequence);
                //. this.transform.position = new Vector3(this.transform.position.x , this.transform.position.y, this.transform.position.z+1);
                time++;
            }

        }
    }
}
