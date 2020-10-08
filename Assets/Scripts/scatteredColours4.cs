using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scatteredColours4 : MonoBehaviour
{

    public int collectedPieces;

    public GameObject[] pieces;

    public bool collected;
    public int finalCollectedPieces;

    public Sprite[] finalPieces;
    // Start is called before the first frame update
    void Start()
    {
        collectedPieces = 0;
        pieces = GameObject.FindGameObjectsWithTag("scattered");

    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.tag == ("blueScattered"))
        {
            finalCollectedPieces = pieces[0].GetComponent<scatteredColours2>().collectedPieces + pieces[1].GetComponent<scatteredColours2>().collectedPieces + pieces[2].GetComponent<scatteredColours2>().collectedPieces +
                pieces[3].GetComponent<scatteredColours2>().collectedPieces;


      
      
            if (finalCollectedPieces == 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[1];
            }
            if (finalCollectedPieces == 2)
            {
              
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[2];
            }
            if (finalCollectedPieces == 3)
            {
                this.gameObject.tag = ("Blue");
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[3];
            }
             if (finalCollectedPieces == 4)
            {
                this.gameObject.tag = ("Blue");
                Debug.Log("Collected all pieces");
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[3];
            }
          

        }
        else if (this.gameObject.transform.tag == ("redScattered"))
        {
            finalCollectedPieces = pieces[0].GetComponent<scatteredColours2>().collectedPieces + pieces[1].GetComponent<scatteredColours2>().collectedPieces + pieces[2].GetComponent<scatteredColours2>().collectedPieces +
                 pieces[3].GetComponent<scatteredColours2>().collectedPieces;




            if (finalCollectedPieces == 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[1];
            }
            if (finalCollectedPieces == 2)
            {

                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[2];
            }
            if (finalCollectedPieces == 3)
            {
                this.gameObject.tag = ("Blue");
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[3];
            }
            if (finalCollectedPieces == 4)
            {
                this.gameObject.tag = ("Red");
                Debug.Log("Collected all pieces");
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[3];
            }

        }


    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (this.gameObject.transform.tag == ("scattered") && collected == false)

        {
            Debug.Log("picked up a scattered piece");
            collectedPieces++;
            collected = true;
            this.gameObject.SetActive(false);

        }


    }
}
