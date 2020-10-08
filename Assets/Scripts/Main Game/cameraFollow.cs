using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 0.15f;
    public Vector3 offset;

    public Collider2D right;
    public Collider2D left;
    public Collider2D up;
    public Collider2D down;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
   

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == ("Blob") && right)
        {
            gameObject.transform.position = new Vector3(transform.position.x + 5, transform.position.y) ;
        }
    }
}
