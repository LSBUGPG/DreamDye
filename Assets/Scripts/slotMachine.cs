using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slotMachine : MonoBehaviour
{
    public GameObject[] colours;
    public int index;
    public float waitTime;

    // Start is called before the first frame update
    void Start()
    {
        wait();
        index = 0;
        Instantiate(colours[index], this.gameObject.transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
     
        
        if(index > colours.Length)
        {
            index = 0;
        }
      
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
       
        Instantiate(colours[index], this.gameObject.transform.position, Quaternion.identity);
        wait();
        index++;

    }
}
