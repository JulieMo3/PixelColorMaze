using UnityEngine;

public class TileMapGenerator : MonoBehaviour
{
    [SerializeField]
    public int gridWidth;
    [SerializeField]
    public int gridHeight;
    [SerializeField]
    TileInfo tilePrefab;
    public float tileOffset = 1.05f;
    public Vector3 startPlayerPos;
    public GameObject [] tiles;
    void Awake()
    {
        //CreateQuadTileMap();
    }

    public void CreateQuadTileMap()
    {
        for (int x = 0; x < gridWidth; x++)
        {
            for (int z = 0; z < gridHeight; z++)
            {
                
                TileInfo tempGo = Instantiate(tilePrefab);
                tempGo.transform.parent = gameObject.transform;
                tempGo.transform.position = new Vector3(x * tileOffset, 0, z * tileOffset);
                SetTileInfo(tempGo, x, z);
                tempGo.gameObject.layer = 6;
                if (Manager.instance.fieldArray.fieldManager[x, z] == 7)
                {
                    tempGo.gameObject.layer = 7;
                    tempGo.tag = "Border";
                    tempGo.transform.GetComponent<MeshRenderer>().material = Manager.instance.borderColor;
                }
                if (Manager.instance.fieldArray.fieldManager[x, z] == 1)
                {
                    Manager.instance.player.InstantiatePlayerPos(tempGo.transform.position.x, tempGo.transform.position.z);
                    startPlayerPos = Manager.instance.player.transform.position;
                }
                if (Manager.instance.fieldArray.fieldManager[x, z] == 2)
                {
                    Manager.instance.mobs.mobBlueInitiate(tempGo.transform.position.x, tempGo.transform.position.z, this.gameObject);
                    Manager.instance.nbBlueMob++;
                }
                if (Manager.instance.fieldArray.fieldManager[x, z] == 3)
                {
                    Manager.instance.mobs.mobGreenInitiate(tempGo.transform.position.x, tempGo.transform.position.z, this.gameObject);
                    Manager.instance.nbGreenMob++;
                }
                if (Manager.instance.fieldArray.fieldManager[x, z] == 4)
                {
                    Manager.instance.mobs.mobRedInitiate(tempGo.transform.position.x, tempGo.transform.position.z, this.gameObject);
                    Manager.instance.nbRedMob++;
                }
                if (Manager.instance.fieldArray.fieldManager[x, z] == 5)
                {
                    Manager.instance.winItem.WinRedInitiate(tempGo.transform.position.x, tempGo.transform.position.z, this.gameObject);
                    Manager.instance.winColor = Manager.Color.red;
                }
                if (Manager.instance.fieldArray.fieldManager[x, z] == 6)
                {
                    Manager.instance.winItem.WinBlueInitiate(tempGo.transform.position.x, tempGo.transform.position.z, this.gameObject);
                    Manager.instance.winColor = Manager.Color.blue;
                }
                if (Manager.instance.fieldArray.fieldManager[x, z] == 8)
                {
                    Manager.instance.winItem.WinGreenInitiate(tempGo.transform.position.x, tempGo.transform.position.z, this.gameObject);
                    Manager.instance.winColor = Manager.Color.green;
                }


            }
        }
    }

    void SetTileInfo(TileInfo tempGo, int x, int z)
    {
        tempGo.transform.parent = transform;
        tempGo.name = x.ToString() + " , " + z.ToString();
        tempGo.xPos = x;
        tempGo.zPos = z;
        

    }


    public void ClearTileColor()
    {
        foreach (Transform child in transform)
        {
            if(child.tag == "Tile" || child.tag == "Border2")
            {
                child.GetComponent<MeshRenderer>().material = Manager.instance.baseColor;
            }
            
        }

    }

    public void ClearTab()
    {

        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject);
            
        }
        Manager.instance.nbRedMob = 0;
        Manager.instance.nbBlueMob = 0;
        Manager.instance.nbGreenMob = 0;
        Manager.instance.isLosable = false;
    }

}
