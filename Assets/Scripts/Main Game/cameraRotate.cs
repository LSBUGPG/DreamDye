using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraRotate : MonoBehaviour
{
    public float rotationSpeed = 5f;
    public GameObject position;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {

            transform.RotateAround(position.transform.position, Vector3.forward * rotationSpeed, 500 * Time.deltaTime);


        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0 )
        {

            transform.RotateAround(position.transform.position, Vector3.back * rotationSpeed, 500 * Time.deltaTime);

        }
    }
   
}
