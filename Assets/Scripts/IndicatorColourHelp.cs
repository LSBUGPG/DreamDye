using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorColourHelp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(this.gameObject.name == "Orange Indicator")
        {
            GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.54f, 0.1f);
        }  
        if(this.gameObject.name == "Purple Indicator")
        {
            GetComponent<SpriteRenderer>().color = new Color(0.5f, 0, 0.5f);
        }
    
    }

    // Update is called once per frame
    void Update()
    {
     
       
    }
}
