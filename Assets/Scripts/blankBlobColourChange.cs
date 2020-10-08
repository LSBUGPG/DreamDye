using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blankBlobColourChange : MonoBehaviour
{
    public Sprite green;
    public Sprite blue;
    public Sprite yellow;
    public Sprite red;
    public Sprite purple;
    public Sprite orange;

    SpriteRenderer rend;
    public GameObject blob;
   

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        blob = GameObject.Find("Blob");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == Color.yellow) || (collision.transform.tag == "Yellow"))
        {
            rend.color = Color.yellow;

        }
        if ((collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == Color.red) || (collision.transform.tag == "Red"))
        {
            rend.color = Color.red;

        }
        if ((collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == Color.blue) || (collision.transform.tag == "Blue"))
        {
            rend.color = Color.blue;

        }
      
        if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == Color.green)
        {
            rend.color = Color.green;

        }

    }
}
