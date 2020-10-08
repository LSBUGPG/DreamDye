using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paintPick : MonoBehaviour
{

    public Material[] material;

    public List<Material> coloursList;

    public bool youGotYellow;
    public bool youGotBlue;
    public bool youRU;



    MeshRenderer rend;

    // Start is called before the first frame update
    void Start()
    {
      
  
    }

    // Update is called once per frame
    void Update()
    {
        rend = GetComponent<MeshRenderer>();
        if ( youRU == false && (rend.sharedMaterial = material[0]))
        {
            Debug.Log("You are white");
            coloursList.Add(material[0]);
            youRU = true;

        }
        if (youGotYellow == false && (rend.sharedMaterial = material[1]))
        {
            Debug.Log("You are yellow");
            coloursList.Add(material[1]);
            youGotYellow = true;

        }
        if (youGotBlue == false && (rend.sharedMaterial = material[2]))
        {
            Debug.Log("You are blue");
            coloursList.Add(material[2]);
            youGotBlue = true;

        }






    }
}
