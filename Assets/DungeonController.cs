using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DungeonController : MonoBehaviour
{
    public Tilemap darkmap;
    public Tile darktile;

    // Start is called before the first frame update
    void Start()
    {



        darkmap.origin  = BackgroundMap.origin;
        darkmap.size  = BackgroundMap.size;

        foreach (Vector3Int p in DarkMap.cellBounds.allPositionsWithin)
        {
            DarkMap.SetTile(p, DarkTile);
        }



        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
