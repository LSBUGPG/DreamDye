using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class groundColoursTilemap : MonoBehaviour
{
    public Tile yellow;
    public Tile blue;
    public Tile green;
    public Tile orange;
    public Tile purple;
    public Tile red;


    public Tilemap tilemap;

    public GameObject player;


    public Tile groundGrey;

    private Vector3Int previous;

    public int amountOfTilesInScene;
    public int currentTileNum;

    public bool dyed;
    public TileBase[] allTiles;

    public List<TileBase> grey = new List<TileBase>();
    // Start is called before the first frame update
    void Start()
    {

            BoundsInt bounds = tilemap.cellBounds;
            allTiles = tilemap.GetTilesBlock(bounds);
            int greyTiles = 0;
            for (int x = 0; x < bounds.size.x; x++)
            {
                for (int y = 0; y < bounds.size.y; y++)
                {
                    TileBase tile = allTiles[x + y * bounds.size.x];
                    if (tile != null)
                    {
                        //Debug.Log("x:" + x + " y:" + y + " tile:" + tile.name);
                        if (tile.name == "Groundgrey")
                        {
                            grey.Add(tile);
                        }
                    }
                    else
                    {
                        //Debug.Log("x:" + x + " y:" + y + " tile: (null)");
                    }
                }
            }

            Debug.LogFormat("There are {0} grey tiles", grey.Count);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTileNum = 0;
    }
    private void LateUpdate()
    {
        // Vector3 hitPosition = player.transform.position + new Vector3(0f, -1f, 0f);
        // if (tilemap.GetTile(tilemap.WorldToCell(hitPosition)) == yellow)
        // {
          
        //     Debug.Log("A change has occured");
        // }

        List<TileBase> changed = grey.FindAll((tile) => tile.name != "Groundgrey");
        foreach (TileBase tile in changed)
        {
            Debug.Log("A change has occured");
            grey.Remove(tile);

            if (grey.Count == 0)
            {
                Debug.Log("All tiles changed!");
            }
        }
    }
   
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (player.GetComponent<SpriteRenderer>().color == Color.yellow)
        {
            currentTileNum++;
            Vector3 hitPosition = player.transform.position + new Vector3(0f, -1f, 0f);

            tilemap.SetTile(tilemap.WorldToCell(hitPosition), yellow);
            tilemap.SetTile(previous, null);
        

        }
        if (player.GetComponent<SpriteRenderer>().color == Color.blue)
        {
            Vector3 hitPosition = player.transform.position + new Vector3(0f, -1f, 0f);

            tilemap.SetTile(tilemap.WorldToCell(hitPosition), blue);
            tilemap.SetTile(previous, null);
        }  
        if (player.GetComponent<SpriteRenderer>().color == Color.green)
        {
            Vector3 hitPosition = player.transform.position + new Vector3(0f, -1f, 0f);

            tilemap.SetTile(tilemap.WorldToCell(hitPosition), green);
            tilemap.SetTile(previous, null);
        } 
        if (player.GetComponent<SpriteRenderer>().color == new Color(1.0f, 0.54f, 0.1f))
        {
            Vector3 hitPosition = player.transform.position + new Vector3(0f, -1f, 0f);

            tilemap.SetTile(tilemap.WorldToCell(hitPosition), orange);
            tilemap.SetTile(previous, null);
        }  
        if (player.GetComponent<SpriteRenderer>().color == new Color(0.5f, 0, 0.5f))
        {
            Vector3 hitPosition = player.transform.position + new Vector3(0f, -1f, 0f);

            tilemap.SetTile(tilemap.WorldToCell(hitPosition), purple);
            tilemap.SetTile(previous, null);
        }  if (player.GetComponent<SpriteRenderer>().color == Color.red)
        {
            Vector3 hitPosition = player.transform.position + new Vector3(0f, -1f, 0f);

            tilemap.SetTile(tilemap.WorldToCell(hitPosition), red);
            tilemap.SetTile(previous, null);
        }
    }

}
