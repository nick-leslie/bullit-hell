using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEditor;
public class TileAutomator : MonoBehaviour
{
    [Range(0, 100)]
    public int iniChance;

    [Range(1,8)]
    public int birthlimit;

    [Range(1, 8)]
    public int deathLimit;

    [Range(1,10)]
    public int numberRep;
    private int count = 0;

    private int[,] tarramap;
    public Vector3Int tmapSize;

    public Tilemap topmap;
    public Tilemap bottomMap;
    public Tile toptile;
    public Tile bottomtile;

    public int width;
    public int hight;

    public void doSim(int nummberRep) 
    {
        clearMap(false);
        width = tmapSize.x;
        hight = tmapSize.y;
    

        if (tarramap == null)
        {
            tarramap = new int[width, hight];
            inipos();
        }

        for (int i = 0; i < numberRep; i++)
        {
            tarramap = genTillePos(tarramap);
        }
        
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < hight; y++)
            {
                if (tarramap[x, y] == 1)
                    topmap.SetTile(new Vector3Int(-x + width / 2, -y + hight / 2, 0), toptile);
                bottomMap.SetTile(new Vector3Int(-x + width / 2, -y + hight / 2, 0), bottomtile);
            }
        }
    }

    public int[,] genTillePos(int[,] oldmap)
    {
        int[,] newMap = new int[width, hight];
        int neighbors;
        BoundsInt myB = new BoundsInt(-1, -1, 0, 3, 3, 1);
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < hight; y++)
            {
                neighbors = 0;
                foreach (var b in myB.allPositionsWithin)
                {
                    if (b.x == 0 && b.y == 0) continue;
                    if (x + b.x >= 0 && x + b.x < width && y + b.y >= 0 && y + b.y < hight)
                    {
                        neighbors += oldmap[x + b.x, y + b.y];

                    }
                    else
                    {
                        neighbors++;
                    }
                }
                if (oldmap[x, y] == 1)
                {
                    if (neighbors < deathLimit) newMap[x, y] = 0;
                    else
                    {
                        newMap[x, y] = 1;
                    }

                }
                if (oldmap[x, y] == 0)
                {
                    if (neighbors > birthlimit) newMap[x, y] = 1;
                    else
                    {
                        newMap[x, y] = 0;
                    }

                }
            }

        }


        return newMap;
    }

    public void inipos()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < hight; y++)
            {
                tarramap[x, y] = Random.Range(1, 101) < iniChance ? 1:0;
            }
        }

    }
   
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.G))
        {
            doSim(numberRep);
        }
      if (Input.GetKeyDown(KeyCode.C))
        {
            clearMap(true);
        }
    }

    public void clearMap(bool complpleat)
    {
        topmap.ClearAllTiles();
        bottomMap.ClearAllTiles();

        if (complpleat) 
        {
            tarramap = null;

        }
    }
}
