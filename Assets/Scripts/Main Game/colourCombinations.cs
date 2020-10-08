using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colourCombinations : MonoBehaviour
{
    public GameObject canvas;

    public GameObject blob;
    public GameObject foundOrange;
    public GameObject foundGreen;

    public static colourCombinations Instance;

    public bool iFoundOrange;
    public bool iFoundPurple;
    public bool iFoundGreen;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
       
   


    }
    private void Start()
    {
        
            canvas.GetComponent<Canvas>().enabled = false;

        if (iFoundGreen == true)
        {
            foreach (Image image in foundGreen.GetComponentsInChildren<Image>())
            {
                image.enabled = true;
            }
        }
        if (iFoundOrange == true)
        {
            foreach (Image image in foundOrange.GetComponentsInChildren<Image>())
            {
                image.enabled = true;
            }

        }


    }



    // Update is called once per frame
    void Update()
    {
       
        canvas = GameObject.Find("ColourComFound");
        foundOrange = GameObject.Find("Orange");
        foundGreen = GameObject.Find("Green");
        blob = GameObject.Find("Blob");
       
        foundGreen.GetComponentsInChildren<Image>();
      
        foundOrange.GetComponentsInChildren<Image>();

   
        if (Input.GetKeyDown(KeyCode.T) && canvas.GetComponent<Canvas>().enabled == false)
        {
            canvas.GetComponent<Canvas>().enabled = true;

        }
        else if(Input.GetKeyDown(KeyCode.T) && canvas.GetComponent<Canvas>().enabled == true)
        {
            canvas.GetComponent<Canvas>().enabled = false;
        }
        if(blob.GetComponent<colourChange>().Orange == true && iFoundOrange == false)
        {

           
            iFoundOrange = true;
          

        }

        if(blob.GetComponent<colourChange>().Green == true && iFoundGreen == false)
        {

         
            iFoundGreen = true;
            
        }
       
        if (blob.GetComponent<colourChange>().Purple == true)
        {

            iFoundPurple = true;
        }
        if (iFoundGreen == true)
        {
            foundGreen.GetComponent<Text>().enabled = true;
            foreach (Image image in foundGreen.GetComponentsInChildren<Image>())
            {
                image.enabled = true;
            }
            foreach (Text text in foundGreen.GetComponentsInChildren<Text>())
            {
                text.enabled = true;
            }
        }
        if (iFoundOrange == true)
        {
            foundOrange.GetComponent<Text>().enabled = true;
            foreach (Image image in foundOrange.GetComponentsInChildren<Image>())
            {
                image.enabled = true;
            }
            foreach (Text text in foundGreen.GetComponentsInChildren<Text>())
            {
                text.enabled = true;
            }
        }
    }
    
}
