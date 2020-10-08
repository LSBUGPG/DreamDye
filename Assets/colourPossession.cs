using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourPossession : MonoBehaviour
{

    private bool clicked;
    public GameObject[] colour;


    // Start is called before the first frame update
    void Start()
    {foreach (GameObject c in colour)
        {
            GetComponent<characterMovement>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if(clicked == false)
        {
            Debug.Log("Clicked a colour");
            GetComponent<characterMovement>().enabled = true;
            clicked = true;

        }
        if(clicked == true)
        {

            Debug.Log("Clicked a colour");
            GetComponent<characterMovement>().enabled = false;
            clicked = false;
        }
      

    }
}
