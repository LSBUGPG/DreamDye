using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brushBehaviour : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
 GameObject brushDestroy;

    // Start is called before the first frame update
    void Start()
    {
        brushDestroy = GameObject.FindGameObjectWithTag("brushDestroyPoint");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-Vector2.down* speed * Time.deltaTime);
        
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == ("brushDestroyPoint"))
        {
            Destroy(this.gameObject);
        }
    }
}
