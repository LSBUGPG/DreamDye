using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colourChange : MonoBehaviour
{

    SpriteRenderer rend;

    public Sprite[] sprites;
    public GameObject[] paintBuckets;


    public Material[] material;


    public bool Yellow;
    public bool Blue;
    public bool Green;
    public bool Red;
    public bool Orange;
    public bool Purple;


    public List<Sprite> coloursList;

    public bool firstTouchedYellow;
    public bool firstTouchedBlue;
    public bool firstTouchedGreen;
    public bool firstTouchedRed;
    public bool firstTouchedOrange;
    public bool firstTouchedPurple;


    public int index;
    public int paintInt;


    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        rend.sprite = sprites[0];
        paintBuckets = GameObject.FindGameObjectsWithTag("Paint Bucket");
        paintInt = 0;
        paintBuckets[0].GetComponent<SpriteRenderer>();
        paintBuckets[2].GetComponent<SpriteRenderer>();
        paintBuckets[3].GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            foreach (Sprite colour in coloursList)
            {
                index++;

            }
        }
        if(Blue == true && Red == true && Orange != true && Green != true)
        {
            rend.color = new Color(0.5f, 0, 0.5f); 

            Purple = true;
  
        }
        if (Blue == true && Yellow == true && Orange != true && Purple != true)
        {
            rend.color = Color.green;

            Green = true;
       

        }
        if(Yellow == true && Red == true && Green != true && Purple != true )
        {
            rend.color = new Color(1.0f, 0.54f, 0.1f);

            Orange = true;

        }

        if (rend.color == new Color(1.0f, 0.54f, 0.1f) && firstTouchedOrange == false)
        {
            firstTouchedOrange = true;
            paintInt++;
            coloursList.Add(sprites[5]);
            if (paintInt == 1 && paintInt != 2 && paintInt != 3 && paintInt != 4)
            {
                paintBuckets[0].GetComponent<Image>().color = new Color(1.0f, 0.54f, 0.1f);
            }
            if (paintInt == 2 && paintInt != 1 && paintInt != 3 && paintInt != 4)
            {
                paintBuckets[1].GetComponent<Image>().color = new Color(1.0f, 0.54f, 0.1f);
            }
            if (paintInt == 3 && paintInt != 1 && paintInt != 2 && paintInt != 4)
            {
                paintBuckets[2].GetComponent<Image>().color = new Color(1.0f, 0.54f, 0.1f);
            }
            if (paintInt == 4 && paintInt != 1 && paintInt != 2 && paintInt != 3)
            {
                paintBuckets[3].GetComponent<Image>().color = new Color(1.0f, 0.54f, 0.1f);
            }

        }
        if(rend.color == new Color(0.5f, 0, 0.5f)  && firstTouchedPurple == false)
        {
            firstTouchedPurple = true;
            paintInt++;
            coloursList.Add(sprites[6]);
            if (paintInt == 1 && paintInt != 2 && paintInt != 3 && paintInt != 4)
            {
                paintBuckets[0].GetComponent<Image>().color = new Color(0.5f, 0, 0.5f);
            }
            if (paintInt == 2 && paintInt != 1 && paintInt != 3 && paintInt != 4)
            {
                paintBuckets[1].GetComponent<Image>().color = new Color(0.5f, 0, 0.5f);
            }
            if (paintInt == 3 && paintInt != 1 && paintInt != 2 && paintInt != 4)
            {
                paintBuckets[2].GetComponent<Image>().color = new Color(0.5f, 0, 0.5f);
            }
            if (paintInt == 4 && paintInt != 1 && paintInt != 2 && paintInt != 3)
            {
                paintBuckets[3].GetComponent<Image>().color = new Color(0.5f, 0, 0.5f);
            }

        }


        if (rend.color == Color.green && firstTouchedGreen == false )
        {

            coloursList.Add(sprites[3]);
            firstTouchedGreen = true;
            paintInt++;
            if (paintInt == 1 && paintInt != 2 && paintInt != 3 && paintInt != 4)
            {
                paintBuckets[0].GetComponent<Image>().color = Color.green;
            }
            if (paintInt == 2 && paintInt != 1 && paintInt != 3 && paintInt != 4)
            {
               paintBuckets[1].GetComponent<Image>().color = Color.green;
            }
            if (paintInt == 3 && paintInt != 1 && paintInt != 2 && paintInt != 4)
            {
              paintBuckets[2].GetComponent<Image>().color = Color.green;
            }  
            if (paintInt == 4 && paintInt != 1 && paintInt != 2 && paintInt != 3)
            {
                paintBuckets[3].GetComponent<Image>().color = Color.green;
            } 
         
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == ("Yellow") && Yellow == false)
        {
          
            rend.color = Color.yellow;

            Yellow = true;


            
        }
        if (collision.transform.tag == ("Yellow") && firstTouchedYellow == false)
        {

          
            coloursList.Add(sprites[1]);
            firstTouchedYellow = true;
            paintInt++;
            if (paintInt == 1 && paintInt != 2 && paintInt != 3 && paintInt != 4)
            {
                paintBuckets[0].GetComponent<Image>().color = Color.yellow;
            }
            if (paintInt == 2 && paintInt != 1 && paintInt != 3 && paintInt != 4)
            {
               paintBuckets[1].GetComponent<Image>().color = Color.yellow;
            }
            if (paintInt == 3 && paintInt != 1 && paintInt != 2 && paintInt != 4)
            {
               paintBuckets[2].GetComponent<Image>().color = Color.yellow;
            } 
            if (paintInt == 4 && paintInt != 1 && paintInt != 2 && paintInt != 3)
            {
               paintBuckets[3].GetComponent<Image>().color = Color.yellow; 
            }
        }

            if (collision.transform.tag == ("Blue") && Blue == false)
        {
            rend.color = Color.blue;

            Blue = true;
         


        }
        if (collision.transform.tag == ("Blue") && firstTouchedBlue == false)
        {
            coloursList.Add(sprites[2]);
            firstTouchedBlue = true;
            paintInt++;
            if(paintInt == 1 && paintInt != 2 && paintInt != 3 && paintInt != 4)
            {
                paintBuckets[0].GetComponent<Image>().color = Color.blue;
            }
            if (paintInt == 2 && paintInt != 1 && paintInt != 3 && paintInt != 4)
            {
               paintBuckets[1].GetComponent<Image>().color = Color.blue;
            }
            if (paintInt == 3 && paintInt != 1 && paintInt != 2 && paintInt != 4)
            {
                paintBuckets[2].GetComponent<Image>().color = Color.blue;
            }
            if (paintInt == 4 && paintInt != 1 && paintInt != 2 && paintInt != 3)
            {
               paintBuckets[3].GetComponent<Image>().color = Color.blue;
            }


        }
        if (collision.transform.tag == ("Red"))
        {
    
            rend.color = Color.red;
            Red = true;



        }
        if (collision.transform.tag == ("Red") && firstTouchedRed == false)
        {
            coloursList.Add(sprites[4]);
            firstTouchedRed = true;
            paintInt++;
            if (paintInt == 1 && paintInt != 2 && paintInt != 3 && paintInt != 4)
            {
                paintBuckets[0].GetComponent<Image>().color = Color.red;
            }
            if (paintInt == 2 && paintInt != 1 && paintInt != 3 && paintInt != 4)
            {
                paintBuckets[1].GetComponent<Image>().color = Color.red;
            }
            if (paintInt == 3 && paintInt != 1 && paintInt != 2 && paintInt != 4)
            {
               paintBuckets[2].GetComponent<Image>().color = Color.red;
            }
            if (paintInt == 4 && paintInt != 1 && paintInt != 2 && paintInt != 3)
            {
                paintBuckets[3].GetComponent<Image>().color = Color.red;
            }



        }
        if (collision.transform.tag == ("Water"))
        {
          
            rend.color = Color.white;
            Blue = false;
            Yellow = false;
            Green = false;
            Red = false;
            Purple = false;
            Orange = false;

        }
    }
   
}
