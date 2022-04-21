using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RedMob : MonoBehaviour
{

    int time;
    int turn = 0;
    Sequence sequence;
    Vector3 angle;
    int upDown = 0;
    bool forward = true;
    public GameObject bulletRed;
    // Start is called before the first frame update
    void Awake()
    {
        angle = new Vector3(0, 180, 0);
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
            
            if(upDown == 0)
            {
               
                Instantiate(bulletRed, transform.position, transform.rotation);
                // sequence.Insert(0.3f, transform.DOMoveX(this.transform.position.x+1.05f, 1f)).SetEase(Ease.OutCubic);
                sequence.Insert(0f, transform.DORotate(angle, 0.6f, RotateMode.Fast));
                sequence.Insert(0f, transform.DOJump(new Vector3(this.transform.position.x, transform.position.y + 0.55f, transform.position.z), 0.3f, 1, 0.7f).SetEase(Ease.OutCubic));

                DOTween.Play(sequence);
                //. this.transform.position = new Vector3(this.transform.position.x , this.transform.position.y, this.transform.position.z+1);
                upDown++;
                time++;
            }
            else
            {
                switch (turn)
                {
                    case 0:
                        angle = new Vector3(0, -90, 0);
                        turn++;
                        break;
                    case 1:
                        angle = new Vector3(0, 0, 0);
                        turn++;
                        break;
                    case 2:
                        angle = new Vector3(0, 90, 0);
                        turn++;
                        break;
                    case 3:
                        angle = new Vector3(0, 180, 0);
                        turn = 0;
                        break;

                }
                // sequence.Insert(0.3f, transform.DOMoveX(this.transform.position.x+1.05f, 1f)).SetEase(Ease.OutCubic);
                sequence.Insert(0f, transform.DORotate(angle, 0.6f, RotateMode.Fast));
                sequence.Insert(0f, transform.DOJump(new Vector3(this.transform.position.x, transform.position.y - 0.55f, transform.position.z), 0.3f, 1, 0.7f).SetEase(Ease.OutCubic));

                DOTween.Play(sequence);
                
                //. this.transform.position = new Vector3(this.transform.position.x , this.transform.position.y, this.transform.position.z+1);
                upDown--;
                time++;
            }
        }
    }
}
