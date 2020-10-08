using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roomExit : MonoBehaviour
{

    public bool leftRoom1;
    public bool enteredRoom2;
    public bool leftRoom2;
    public bool enteredRoom3;

    public GameObject virtualCam;

   


   
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
      if(collision.transform.tag == "Blob" && !collision.isTrigger)
        {
            virtualCam.SetActive(true);
            Debug.Log("entered collider");

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Blob" && !collision.isTrigger)
        {
            virtualCam.SetActive(false);
            Debug.Log("Exited Collider");

        }
    }


}
