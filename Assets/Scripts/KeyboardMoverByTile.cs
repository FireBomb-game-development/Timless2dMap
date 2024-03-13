using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;


/**
 * This component allows the player to move by clicking the arrow keys,
 * but only if the new position is on an allowed tile.
 */
public class KeyboardMoverByTile: KeyboardMover {
    [SerializeField] Tilemap tilemap = null;
//    [SerializeField] TileBase[] allowedTiles = null;
    [SerializeField] AllowedTiles allowedTiles = null;

    [SerializeField] float timeToWait;
    [SerializeField] int maxZTile;


    private TileBase TileOnPosition(Vector3 worldPosition) {
        Vector3Int cellPosition = tilemap.WorldToCell(worldPosition);
        return tilemap.GetTile(cellPosition);
    }

    void move()
    {

        Vector3 newPosition = NewPosition();
        Vector3 tempPosition = newPosition;
        TileBase tileOnNewPosition = TileOnPosition(newPosition);
        TileBase tempTile;

        bool validMove = true;


        int x = ((int)(tempPosition.x- 0.5));
        int y = ((int)(tempPosition.y-0.5) );
        var count = tilemap.GetTilesRangeCount(new Vector3Int(x, y, 0), new Vector3Int(x, y, Int32.MaxValue));

        Vector3Int[] positions = new Vector3Int[count];
        TileBase[] tiles = new TileBase[count];
        count = tilemap.GetTilesRangeNonAlloc(new Vector3Int(x, y, 0), new Vector3Int(x, y, Int32.MaxValue), positions, tiles);

      
        foreach (TileBase tile in tiles) {
            
          
            if (!allowedTiles.Contains(tile))
            {
                validMove = false;
            }
        }
    

            if (allowedTiles.Contains(tileOnNewPosition) && validMove )
            {
                transform.position = newPosition;
              

            }

            else
            {
                Debug.Log("You cannot walk on " + tileOnNewPosition + "!");
                
            }
        

    }


    void Update()  {

        move();
    }
}
