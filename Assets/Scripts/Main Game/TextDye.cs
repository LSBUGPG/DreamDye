using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TextDye : MonoBehaviour
{
    //for the menu


    public GameObject blob;
    public Sprite[] sprites;
    public Text play;
    public Text quit;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        blob.GetComponent<SpriteRenderer>();


 
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (blob.GetComponent<SpriteRenderer>().sprite == sprites[0] && this.gameObject.name == "PLAY")
        {
         
            play.color = Color.red;
            StartCoroutine(wait());


        }
        if (blob.GetComponent<SpriteRenderer>().sprite == sprites[1] && this.gameObject.name == "QUIT")
        {
            quit.color = Color.blue;
            StartCoroutine(wait2());
        }

    }
  
    IEnumerator wait()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("The Village");
    }
    IEnumerator wait2()
    {
        yield return new WaitForSeconds(1f);
        Application.Quit();
    }
}
