using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theColours : MonoBehaviour
{

    private Rigidbody2D rb;
    public Sprite white;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Water")
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = white;
            this.gameObject.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        }


        if (collision.gameObject.name == "Moving Platform")
        {
            transform.parent = collision.transform;
            rb.gravityScale = 0;


        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.name == "Moving Platform")
        {
            transform.parent = null;
        }
    }
}
