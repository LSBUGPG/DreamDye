using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scatteredColours2 : MonoBehaviour
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
            finalCollectedPieces = pieces[0].GetComponent<scatteredColours2>().collectedPieces + pieces[1].GetComponent<scatteredColours2>().collectedPieces;


            if (finalCollectedPieces == 4)
            {
                Debug.Log("Collected all pieces");
            }
            if (finalCollectedPieces == 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[1];
            }
            if (finalCollectedPieces == 2)
            {
                this.gameObject.tag = ("Blue");
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[0];
            }

        }
        else if (this.gameObject.transform.tag == ("redScattered"))
        {
            finalCollectedPieces = pieces[0].GetComponent<scatteredColours2>().collectedPieces + pieces[1].GetComponent<scatteredColours2>().collectedPieces;


            if (finalCollectedPieces == 4)
            {
                Debug.Log("Collected all pieces");
            }
            if (finalCollectedPieces == 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[1];
            }
            if (finalCollectedPieces == 2)
            {
                this.gameObject.tag = ("Red");
                this.gameObject.GetComponent<SpriteRenderer>().sprite = finalPieces[0];
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
