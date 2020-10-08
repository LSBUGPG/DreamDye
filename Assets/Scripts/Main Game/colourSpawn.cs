using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourSpawn : MonoBehaviour
{

    public GameObject[] colours;
    public float fireRate;

    // Start is called before the first frame update
    void Start()
    {
     
        StartCoroutine(instantiate());
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    public void createColour()
    {
        int colourRange = Random.Range(0, colours.Length);

        Instantiate(colours[colourRange], this.gameObject.transform.position, Quaternion.identity);
    }
    IEnumerator instantiate()
    {
        yield return new WaitForSeconds(fireRate);
        createColour();
        StartCoroutine(instantiate());
    }
}
