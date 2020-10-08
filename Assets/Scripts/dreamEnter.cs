using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dreamEnter : MonoBehaviour
{
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
        if(this.gameObject.name == ("BedHouse1"))
        {
            wait();
            SceneManager.LoadScene("level1");

        }  
        if(this.gameObject.name == ("BedHouse2"))
        {
            wait();
            SceneManager.LoadScene("level6");

        }  
      
        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);

    }
}

