using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyingColours : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector3.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == ("Warphole"))
        {
            Destroy(this.gameObject);
        }
        if(collision.transform.tag == ("Blue Gate") || collision.transform.tag == ("Red Gate")|| collision.transform.tag == ("Green Gate"))
        {
    
            speed = -5f;
        }
    }
}
