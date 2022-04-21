using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayManager : MonoBehaviour
{
    public int[,] fieldManager;
  

    public void GetPlayerMove(TileInfo tile)
    {
        //Debug.Log(fieldManager[tile.xPos, tile.zPos]);
        for(int x = 0; x< Manager.instance.tileMapGenerator.gridWidth; x++)
        {
            for (int z = 0; z < Manager.instance.tileMapGenerator.gridHeight; z++)
            {
                if (x == tile.xPos && z == tile.zPos)
                {
                    fieldManager[x, z] = 1;
                }
                else
                {
                    fieldManager[x, z] = 0;
                }
                
            }

        }
        
    }
}
