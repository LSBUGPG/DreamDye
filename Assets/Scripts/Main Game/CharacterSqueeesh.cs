using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSqueeesh : MonoBehaviour
{

    public GameObject[] LeftSides;
    public GameObject[] RightSides;
    public GameObject[] BottomSides;
    public GameObject[] TopSides;

    public bool touchedLeftOnce;
    public bool touchedRightOnce;
    public bool touchedTopOnce;
    public bool touchedBotOnce;


    // Start is called before the first frame update
    void Start()
    {
        LeftSides = GameObject.FindGameObjectsWithTag("LeftPlatform");
         RightSides = GameObject.FindGameObjectsWithTag("RightPlatform");
        TopSides = GameObject.FindGameObjectsWithTag("TopPlatform");
        BottomSides = GameObject.FindGameObjectsWithTag("BottomPlatform");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == ("LeftPlatform") || collision.transform.tag == ("RightPlatform"))
        {
            this.gameObject.transform.localScale = new Vector2(1f, 1);
           

        }
        if (collision.transform.tag == ("TopPlatform") || collision.transform.tag == ("BottomPlatform"))
        {
            this.gameObject.transform.localScale = new Vector2(1, 1f);
            this.gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.transform.tag == ("LeftPlatform")  || collision.transform.tag == ("RightPlatform"))
       {
          this.gameObject.transform.localScale = new Vector2(0.75f, 1);
         
          StartCoroutine(wait());
           

        }
      if(collision.transform.tag == ("TopPlatform") || collision.transform.tag == ("BottomPlatform"))
      {
            this.gameObject.transform.localScale = new Vector2(1, 0.75f);
            this.gameObject.transform.position = new Vector2(transform.position.x , transform.position.y - 0.5f);
            StartCoroutine(wait());

       }
   }
    
    IEnumerator squish()
    {
        yield return new WaitForSeconds(0.05f);
   
        this.gameObject.transform.localScale = new Vector2(1, 0.9f);
    }
    IEnumerator wait()
   {
       yield return new WaitForSeconds(0.15f);
       this.gameObject.transform.localScale = new Vector2(1, 1);
        this.gameObject.transform.position = new Vector2(transform.position.x, transform.position.y + 0.5f);
    }
}
