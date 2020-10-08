using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removePlatformSwitch : MonoBehaviour
{
    public GameObject[] GreenGate;
    public GameObject[] YellowGate;
    public GameObject[] BlueGate;
    public GameObject[] RedGate;
    public GameObject[] PurpleGate;
    public GameObject[] OrangeGate;
    public GameObject[] BlankGate;


    public GameObject redSwitch;
    public GameObject blueSwitch;
    public GameObject greenSwitch;
    public GameObject blankSwitch;
    public GameObject yellowSwitch;



    // Start is called before the first frame update
    void Start()
    {
        GreenGate = GameObject.FindGameObjectsWithTag("Green Gate");
        YellowGate = GameObject.FindGameObjectsWithTag("Yellow Gate");
        BlueGate = GameObject.FindGameObjectsWithTag("Blue Gate");
        RedGate = GameObject.FindGameObjectsWithTag("Red Gate");
        PurpleGate = GameObject.FindGameObjectsWithTag("Purple Gate");
        OrangeGate = GameObject.FindGameObjectsWithTag("Orange Gate");
        BlankGate = GameObject.FindGameObjectsWithTag("Gate");
        redSwitch = GameObject.FindGameObjectWithTag("redSwitch");
       greenSwitch = GameObject.FindGameObjectWithTag("greenSwitch");      
        yellowSwitch = GameObject.FindGameObjectWithTag("yellowSwitch");
        blueSwitch = GameObject.FindGameObjectWithTag("blueSwitch");
        blankSwitch = GameObject.FindGameObjectWithTag("blankSwitch");


    }

        // Update is called once per frame
        void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(this.gameObject.tag == "blankSwitch")
        {
            foreach (GameObject gate in BlankGate)
            {
                gate.SetActive(false);


            }
        }
        if(this.gameObject.tag == "redSwitch")
        {
            foreach (GameObject gate in RedGate)
            {
                gate.SetActive(false);


            }
            foreach (GameObject greengate in GreenGate)
            {
                greengate.SetActive(true);

            }
            foreach (GameObject bluegate in BlueGate)
            {
                bluegate.SetActive(true);
            }
            foreach (GameObject yellowgate in YellowGate)
            {
                yellowgate.SetActive(true);
            }
        }
        if(this.gameObject.tag == "blueSwitch")
        {
            foreach (GameObject gate in BlueGate)
            {
                gate.SetActive(false);               
            }
            foreach (GameObject redgate in RedGate)
            {
                redgate.SetActive(true);

            }
            foreach (GameObject greengate in GreenGate)
            {
                greengate.SetActive(true);
            }
            foreach (GameObject yellowgate in YellowGate)
            {
                yellowgate.SetActive(true);
            }
        } 
        if(this.gameObject.tag == "greenSwitch")
        {
            foreach (GameObject gate in GreenGate)
            {
                gate.SetActive(false);
            }
            foreach (GameObject redgate in RedGate)
            {
                redgate.SetActive(true);

            }
            foreach (GameObject bluegate in BlueGate)
            {
                bluegate.SetActive(true);
            }
            foreach (GameObject yellowgate in YellowGate)
            {
                yellowgate.SetActive(true);
            }
        }
        if(this.gameObject.tag == "yellowSwitch")
        {
            foreach (GameObject gate in GreenGate)
            {
                gate.SetActive(true);
            }
            foreach (GameObject redgate in RedGate)
            {
                redgate.SetActive(true);

            }
            foreach (GameObject bluegate in BlueGate)
            {
                bluegate.SetActive(true);
            } 
            foreach (GameObject yellowgate in YellowGate)
            {
                yellowgate.SetActive(false);
            }
        }
    }
}
