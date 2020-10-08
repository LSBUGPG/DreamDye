using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class split : MonoBehaviour
{
    public GameObject blob;
    GameObject rend;

    public Material blue;
    public Material yellow;

        public Material green;
    public GameObject paintBrush2;

    public bool hasSplit;

    public bool mustBeYellow;

    public bool isGreen;
    public bool isBlue;
    public bool isYellow;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(blob.GetComponent<Renderer>().sharedMaterial == green && Input.GetKeyDown(KeyCode.Q) && hasSplit == false)
        {
            Instantiate(paintBrush2, this.gameObject.transform.position + new Vector3(2, 0,0), Quaternion.identity);
            hasSplit = true;

            mustBeYellow = true;
            StartCoroutine(wait());
        }
        if(this.gameObject.GetComponent<Renderer>().sharedMaterial == green)
        {
            isGreen = true;
        }
        if (this.gameObject.GetComponent<Renderer>().sharedMaterial == blue)
        {
            isBlue = true;
        }
        if (this.gameObject.GetComponent<Renderer>().sharedMaterial == yellow)
        {
            isYellow = true;
        }
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
        paintBrush2.GetComponent<Renderer>().sharedMaterial = blue;
 
        blob.transform.localScale = new Vector3(0.9f,0.9f,0.9f);
        paintBrush2.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
    }
}
