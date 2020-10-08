using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class NextLevel : MonoBehaviour
{
    public GameObject indicator;
    public GameObject Object;


    public Sprite[] indicatorSprites;

    public Sprite[] sprites;

    public GameObject swiitch;



    public GameObject blob;

    // Start is called before the first frame update
    void Start()
    {
        indicator.GetComponent<SpriteRenderer>();
        Object.GetComponent<SpriteRenderer>();
        blob.GetComponent<SpriteRenderer>();
  
    }

    // Update is called once per frame
    void Update()
    {
       

        if (Object.GetComponent<SpriteRenderer>().color == indicator.GetComponent<SpriteRenderer>().color)
        { 
          
            StartCoroutine(wait());
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (blob.GetComponent<SpriteRenderer>().color == Color.green)
        {
            Object.GetComponent<SpriteRenderer>().color = Color.green;

        }
        if (blob.GetComponent<SpriteRenderer>().color == Color.yellow)
        {
            Object.GetComponent<SpriteRenderer>().color = Color.yellow;

        }
        if (blob.GetComponent<SpriteRenderer>().color == Color.blue)
        {
            Object.GetComponent<SpriteRenderer>().color = Color.blue;

        }
        if (blob.GetComponent<SpriteRenderer>().color == Color.red)
        {
            Object.GetComponent<SpriteRenderer>().color = Color.red;

        }
        if (blob.GetComponent<SpriteRenderer>().color == new Color(1.0f, 0.54f, 0.1f))
        {
            Object.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.54f, 0.1f);

        }
        if (blob.GetComponent<SpriteRenderer>().color == new Color(0.5f, 0, 0.5f))
        {
            Object.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0, 0.5f);

        }
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (blob.GetComponent<SpriteRenderer>().color == Color.green)
        {
            Object.GetComponent<SpriteRenderer>().color = Color.green;

        }
        if (blob.GetComponent<SpriteRenderer>().color == Color.yellow)
        {
            Object.GetComponent<SpriteRenderer>().color = Color.yellow;

        }
        if (blob.GetComponent<SpriteRenderer>().color == Color.blue)
        {
            Object.GetComponent<SpriteRenderer>().color = Color.blue;

        }
        if (blob.GetComponent<SpriteRenderer>().color == Color.red)
        {
            Object.GetComponent<SpriteRenderer>().color = Color.red;

        }
        if (blob.GetComponent<SpriteRenderer>().color == new Color(1.0f, 0.54f, 0.1f))
        {
            Object.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.54f, 0.1f);

        }
        if (blob.GetComponent<SpriteRenderer>().color == new Color(0.5f, 0, 0.5f))
        {
            Object.GetComponent<SpriteRenderer>().color = new Color(0.5f, 0, 0.5f);

        }
    }

}
