using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformHit : MonoBehaviour
{
    public GameObject blob;

    public float minAngle = 0;
    public float maxAngle = 45;

    public bool canRotate;

    public BoxCollider2D left;
    public BoxCollider2D right;

    public bool turnedLeft;
    public bool turnedRight;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            
          
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if ((left))
        {

            float angle = Mathf.LerpAngle(minAngle, -maxAngle, Time.time);
            transform.eulerAngles = new Vector3(0, 0, angle);
            Debug.Log("LeftSide");
            turnedLeft = true;
            turnedRight = false;


        }
        else if ((right))
        {
            float angle = Mathf.LerpAngle(minAngle, maxAngle, Time.time);
            transform.eulerAngles = new Vector3(0, 0, angle);
            Debug.Log("RightSide");
            turnedRight = true;
            turnedLeft = false;

        }
    }

}
