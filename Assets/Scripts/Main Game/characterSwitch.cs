using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSwitch : MonoBehaviour
{
    public GameObject[] characters;
    int charactersIndex;
    GameObject currentCharacter;

    public GameObject paintBrush;

    GameObject blobTwin;
    // Start is called before the first frame update
    void Start()
    {
        charactersIndex = 0;
        currentCharacter = characters[0];


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("c"))
        {
            charactersIndex++;
            if (charactersIndex == characters.Length)
            {
                charactersIndex = 0;

            }
            currentCharacter.GetComponent<characterMovement>().enabled = false;
            characters[charactersIndex].GetComponent<characterMovement>().enabled = true;
            currentCharacter = characters[charactersIndex];
   



        }


        if (paintBrush.GetComponent<split>().hasSplit == true)
        {
            blobTwin = GameObject.FindGameObjectWithTag("blob2");
            characters[1] = blobTwin;


        }
    }

}
