using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateEntry : MonoBehaviour
{

    public GameObject blob;
    GameObject blobTwin;

    
    public Sprite green;
    public Sprite blue;
    public Sprite yellow;
    public Sprite red;
    public Sprite purple;
    public Sprite orange;


    public Collider2D colliderr;

   public GameObject[] GreenGate;
    public GameObject[] YellowGate;
    public GameObject[] BlueGate;
    public GameObject[] RedGate;
    public GameObject[] PurpleGate;
    public GameObject[] OrangeGate;





    // Start is called before the first frame update
    void Start()
    {
        GreenGate = GameObject.FindGameObjectsWithTag("Green Gate");
        YellowGate = GameObject.FindGameObjectsWithTag("Yellow Gate");
        BlueGate = GameObject.FindGameObjectsWithTag("Blue Gate");
        RedGate = GameObject.FindGameObjectsWithTag("Red Gate");
        PurpleGate = GameObject.FindGameObjectsWithTag("Purple Gate");
        OrangeGate = GameObject.FindGameObjectsWithTag("Orange Gate");
        blob = GameObject.Find("Blob");
    }

    // Update is called once per frame
    void Update()
    {
        blobTwin = GameObject.FindGameObjectWithTag("blob2");

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == ("Yellow") || collision.gameObject.tag == ("Red") || collision.gameObject.tag == ("Blue") )
        {
            this.gameObject.GetComponent<Collider2D>().enabled = true;
        }
        if (colliderr.enabled == false && collision.transform.tag == "Bird")
        {
            GetComponent<BoxCollider2D>().enabled = false;

        }
        if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == Color.green && this.gameObject.transform.tag == ("Green Gate"))

        {
            Debug.Log("green gate");

            foreach (GameObject gate in GreenGate)
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
           


        }
        else
            if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color != Color.green && this.gameObject.transform.tag == ("Green Gate"))
        {
            foreach (GameObject gate in GreenGate)
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }
         if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == new Color(0.5f, 0, 0.5f)  && this.gameObject.transform.tag == ("Purple Gate"))

        {
            Debug.Log("purple gate");

            foreach (GameObject gate in PurpleGate)
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
           


        }
        else
            if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color != new Color(0.5f, 0, 0.5f) && this.gameObject.transform.tag == ("Purple Gate"))
        {
            foreach (GameObject gate in PurpleGate)
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }    
        if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == new Color(1.0f, 0.54f, 0.1f) && this.gameObject.transform.tag == ("Orange Gate"))

        {
            Debug.Log("orange gate");

            foreach (GameObject gate in OrangeGate)
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
           


        }
        else
            if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color != new Color(1.0f, 0.54f, 0.1f) && this.gameObject.transform.tag == ("Orange Gate"))
        {
            foreach (GameObject gate in OrangeGate)
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }


            if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == Color.yellow && this.gameObject.transform.tag == ("Yellow Gate"))

        {
            Debug.Log("yellow gate");
            foreach (GameObject gate in YellowGate)
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
            if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color != Color.yellow && this.gameObject.transform.tag == ("Yellow Gate"))
        {
            foreach (GameObject gate in YellowGate)
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }



        if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == Color.blue && this.gameObject.transform.tag == ("Blue Gate"))

        {
            Debug.Log("blue gate");
            foreach (GameObject gate in BlueGate)
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }

        }
        else
            if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color != Color.blue && this.gameObject.transform.tag == ("Blue Gate"))
        {
            foreach (GameObject gate in BlueGate)
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }
        if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color == Color.red && this.gameObject.transform.tag == ("Red Gate"))

        {
            Debug.Log("red gate");
            foreach (GameObject gate in RedGate)
            {
                GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        else
       if (collision.transform.tag == "Blob" && blob.GetComponent<SpriteRenderer>().color != Color.red && this.gameObject.transform.tag == ("Red Gate"))
        {
            foreach (GameObject gate in RedGate)
            {
                GetComponent<BoxCollider2D>().enabled = true;
            }
        }
    }
   
}
