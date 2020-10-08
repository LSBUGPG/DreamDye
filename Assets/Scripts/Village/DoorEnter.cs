using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DoorEnter : MonoBehaviour
{

    public bool entered;
    public bool exited;

    public bool doctorHouse;
    public bool doctorHInside;
    public bool house1;
    public bool house1Inside;
    public bool house2; 
    public bool house2Inside;
    public bool house3;
    public bool house3Inside;

    public Camera originalCamera;
    public Camera house1Camera;
    public GameObject originalDoctor;
    public GameObject house1Door;
    public GameObject house2Door;
    public GameObject house3Door;
    public GameObject doctorDoor;

    public GameObject doctorInDoctorsHouse;
    public GameObject doctorHouse1;
    public GameObject doctorHouse2;
    public GameObject doctorHouse3;

    public GameObject doctorHInsideDoor;
    public GameObject house1InsideDoor;
    public GameObject house2InsideDoor;
    public GameObject house3InsideDoor;

    // Start is called before the first frame update
    void Start()
    {
        originalCamera.enabled = true;
        house1Camera.enabled = false;

        doctorInDoctorsHouse.SetActive(false);
        doctorHouse1.SetActive(false);
        doctorHouse2.SetActive(false);
        doctorHouse3.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E) && doctorHouse == true)
        {
            originalCamera.enabled = false;
            house1Camera.enabled = true;
            doctorInDoctorsHouse.SetActive(true);
            doctorInDoctorsHouse.transform.position = doctorHInsideDoor.transform.position;
            doctorHouse = false;

      
        }
        if (Input.GetKeyDown(KeyCode.E) && doctorHInside == true)
        {
            Debug.Log("left doctor's house");
            doctorInDoctorsHouse.SetActive(false);
            house1Camera.enabled = false;
            doctorDoor.GetComponent<Transform>();
            originalDoctor.transform.position = doctorDoor.transform.position;
            originalCamera.enabled = true;
            doctorHInside = false;
    
        }
        if (Input.GetKeyDown(KeyCode.E) && house1 == true)
        {
            originalCamera.enabled = false;
            house1Camera.enabled = true;
            doctorHouse1.SetActive(true);
            doctorHouse1.transform.position = house1InsideDoor.transform.position;
            house1 = false;

        }
        if (Input.GetKeyDown(KeyCode.E) && house1Inside == true)
        {
            doctorHouse1.SetActive(false);
            house1Camera.enabled = false;
            house1Door.GetComponent<Transform>();
            originalDoctor.transform.position = house1Door.transform.position;
            originalCamera.enabled = true;
            house1Inside = false;

        }
        if (Input.GetKeyDown(KeyCode.E) && house2 == true)
        {
            doctorHouse2.SetActive(true);
            doctorHouse2.transform.position = house2InsideDoor.transform.position;
            originalCamera.enabled = false;
            house1Camera.enabled = true;
            house2 = false;
        }
        if (Input.GetKeyDown(KeyCode.E) && house2Inside == true)
        {
            doctorHouse2.SetActive(false);
            house1Camera.enabled = false;
            house2Door.GetComponent<Transform>();
            originalDoctor.transform.position = house2Door.transform.position;
            originalCamera.enabled = true;
            house2Inside = false;

        }
        if (Input.GetKeyDown(KeyCode.E) && house3 == true)
        {
            doctorHouse3.SetActive(true);
            doctorHouse3.transform.position = house3InsideDoor.transform.position;
            originalCamera.enabled = false;
            house1Camera.enabled = true;
            house3 = false;
        }
       
        if(Input.GetKeyDown(KeyCode.E) && house3Inside == true)
        {

            doctorHouse3.SetActive(false);
            house1Camera.enabled = false; 
            house3Door.GetComponent<Transform>();

            originalDoctor.transform.position = house3Door.transform.position;
            originalCamera.enabled = true;
            house3Inside = false;

        }
    }
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        if (this.gameObject.name == "Doctor's House")
        {
            doctorHouse = true; 
            entered = true;
        }
        if (this.gameObject.name == ("House1"))
        {
            house1 = true;
            entered = true;
        }
      
     
   

       else if (this.gameObject.name == ("House2"))
        {
            house2 = true;
            entered = true;
        }
     
     
       
         else if (this.gameObject.name == ("House3"))
        {
            house3 = true;
            entered = true;
        }



        if (this.gameObject.name == ("House1Inside"))
        {
            house1Inside = true;
            entered = true;
        }
        if (this.gameObject.name == ("House3Inside"))
        {
            house3Inside = true;
            entered = true;
        }
        if (this.gameObject.name == ("House2Inside"))
        {
            house2Inside = true;
            entered = true;
        }
        if (this.gameObject.name == ("DoctorHInside"))
        {
            doctorHInside = true;
            entered = true;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (this.gameObject.name == ("House1Inside"))
        {
            house1Inside = true;
            entered = true;
        }
        if (this.gameObject.name == ("House3Inside"))
        {
            house3Inside = true;
            entered = true;
        }
        if (this.gameObject.name == ("House2Inside"))
        {
            house2Inside = true;
            entered = true;
        }
        if (this.gameObject.name == ("DoctorHInside"))
        {
            doctorHInside = true;
            entered = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        entered = false;
        exited = true;
        doctorHouse = false;
        doctorHInside = false;
       
        house1Inside = false;
        house2Inside = false;
        house3Inside = false;
        house1 = false;
        house2 = false;
        house3 = false;
    }
}
