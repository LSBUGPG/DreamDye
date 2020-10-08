using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour
{

    public GameObject blob;

    public GameObject[] paint;

    public GameObject theObject;

    public List<Sprite>[] colours;

    public Sprite[] sprite;


    public int pressedQ;

    public bool pressedE;

    public bool nearSwitch;


    // Start is called before the first frame update
    void Start()
    {
        pressedQ = 0;
        nearSwitch = false;
        blob = GameObject.Find("Blob");
    }

    // Update is called once per frame
    void Update()
    {
        paint = blob.GetComponent<colourChange>().paintBuckets;
   
        if (Input.GetKeyDown(KeyCode.E) && nearSwitch == true)
        {
            pressedE = true;
            pressedQ++;
            if (pressedQ > 2)
            {
                pressedQ = 0;
            }
            if (pressedQ == 0)
            {
                theObject.GetComponent<SpriteRenderer>().color = paint[0].GetComponent<Image>().color;
            }
            if(pressedQ == 1)
            {
                theObject.GetComponent<SpriteRenderer>().color = paint[1].GetComponent<Image>().color;
            }
            if(pressedQ == 2)
            {
                theObject.GetComponent<SpriteRenderer>().color = paint[2].GetComponent<Image>().color;
            }

        }

   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        nearSwitch = true;

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nearSwitch = false;
    }
}
