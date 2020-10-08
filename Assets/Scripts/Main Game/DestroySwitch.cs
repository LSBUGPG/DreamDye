using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySwitch : MonoBehaviour
{
    public GameObject breakingPlatform;
    public bool touchedButton;
    public int touchedButtonYesNo;
    // Start is called before the first frame update
    void Start()
    {
        touchedButton = false;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(touchedButtonYesNo == 0)
        {
            touchedButtonYesNo = 0;
        }
        touchedButtonYesNo = 1;
        touchedButton = true;
        if (touchedButton == true && touchedButtonYesNo == 1)
        {
            breakingPlatform.SetActive(false);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        touchedButtonYesNo++;
        if(touchedButtonYesNo == 3)
        {
            touchedButtonYesNo = 0;
        }

        if (touchedButtonYesNo == 2)
        {
            breakingPlatform.SetActive(true);
        }

    }


}
