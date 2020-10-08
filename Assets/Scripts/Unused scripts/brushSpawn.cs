using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brushSpawn : MonoBehaviour
{

    public GameObject[] Brushes;

    public Transform[] spawnPoint;

   
    public int spawnIndex;
    public GameObject spawnObject;

    // Start is called before the first frame update
    void Start()
    {
        brushYeet();
      
    }

    // Update is called once per frame
    void Update()
    {

        spawnIndex = Random.Range(0, spawnPoint.Length);

    }
    public void brushYeet()
    {
        spawnObject = Brushes[Random.Range(0, Brushes.Length)];
        GameObject clone;
        clone = Instantiate(spawnObject, spawnPoint[spawnIndex].position, Quaternion.Euler(0, 0, 90));
        StartCoroutine(wait());
    }

    IEnumerator wait()

    {
        yield return new WaitForSeconds(2);
        brushYeet();

    }
}
