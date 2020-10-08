using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterDispenser : MonoBehaviour
{
    public GameObject water;


    public GameObject left;
    public GameObject right;


    Vector3 leftPos;
    Vector3 rightPos;

    Vector3 instantiatePos;

    public float lerpValue = 5;



    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Transform>();
        left.GetComponent<Transform>();
        right.GetComponent<Transform>();

        leftPos = left.transform.position;
        rightPos = right.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
  
        Instantiate(water, Vector3.Lerp(leftPos, rightPos, lerpValue), Quaternion.identity);

      

    }
}
