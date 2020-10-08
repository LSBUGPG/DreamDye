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

    List<Vector3Int> grey = new List<Vector3Int>();
    // Start is called before the first frame update
    void Start()
    {

        BoundsInt bounds = tilemap.cellBounds;
        allTiles = tilemap.GetTilesBlock(bounds);

 
        foreach (Vector3Int pos in tilemap.cellBounds.allPositionsWithin)
        {
            TileBase tile = tilemap.GetTile(pos);
            if (tile != null)
            {
                if (tile.name == "Groundgrey")
                {
                    grey.Add(pos);
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
        List<Vector3Int> changed = grey.FindAll((pos) => tilemap.GetTile(pos).name != "Groundgrey");
        foreach (Vector3Int pos in changed)
        {
            Debug.Log("A change has occured");
            grey.Remove(pos);
            Debug.LogFormat("There are {0} grey tiles", grey.Count);
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
        }
        if (player.GetComponent<SpriteRenderer>().color == Color.red)
        {
            Vector3 hitPosition = player.transform.position + new Vector3(0f, -1f, 0f);

            tilemap.SetTile(tilemap.WorldToCell(hitPosition), red);
            tilemap.SetTile(previous, null);
        }
    }

}
