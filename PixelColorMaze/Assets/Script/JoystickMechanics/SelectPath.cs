using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPath : MonoBehaviour
{
    Vector3 newPos;
    TileInfo objPosition;
    //public List<Vector3> pathList;
    public int playerXPos;
    public int playerZPos;
    TileInfo oldTile = null;
    public Vector3[] wayPoints;
    public Vector3[] oldWayPoints;
    float moveDuration;
    public int nb;
    bool outOfField;

    void Start()
    {
        nb = 0;
        moveDuration = 0;
        oldWayPoints = new Vector3[0];
        wayPoints = new Vector3[0];
        outOfField = false;

    }


    private void OnTriggerEnter(Collider other)
    {
        if(Manager.instance.player.state == 1)
        {
            if (other.gameObject.CompareTag("Tile"))
            {

                objPosition = other.transform.GetComponent<TileInfo>();
                playerXPos = objPosition.xPos;
                playerZPos = objPosition.zPos;
                this.transform.position = other.transform.position;
                // other.transform.GetComponent<MeshRenderer>().material = Manager.instance.selectColor;
                Darken(other.transform);
                if (objPosition != oldTile)
                {
                    newPos = new Vector3(objPosition.transform.position.x, 0.2f, objPosition.transform.position.z);
                    nb++;
                    moveDuration += 0.3f;
                    wayPoints = new Vector3[nb];
                    for (int i = 0; i < oldWayPoints.Length; i++)
                    {
                        wayPoints[i] = oldWayPoints[i];
                    }
                    wayPoints[nb - 1] = newPos;
                    oldWayPoints = new Vector3[wayPoints.Length];
                    for (int i = 0; i < wayPoints.Length; i++)
                    {
                        oldWayPoints[i] = wayPoints[i];
                    }
                    oldTile = objPosition;

                }
            }
            else if (other.gameObject.CompareTag("Border") || other.gameObject.CompareTag("Border2"))
            {
                this.transform.position = oldTile.transform.position;
            }
        }
        
    }
   void StartPathSelection()
    {

        nb = 0;
    }

    void Darken(Transform other)
    {
        if(other.GetComponent<MeshRenderer>().material.color == Manager.instance.selectColor.color)
        {
          
            other.GetComponent<MeshRenderer>().material = Manager.instance.secondSelectColor;
            other.gameObject.tag = "Border2";
        }
        else
        {
            other.GetComponent<MeshRenderer>().material = Manager.instance.selectColor;
        }
    }

    public Vector3[] GetPath()
    {
        return wayPoints;
    }

      
}
