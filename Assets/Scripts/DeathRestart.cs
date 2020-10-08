using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathRestart : MonoBehaviour
{

    private GameObject blob;

    // Start is called before the first frame update
    void Start()
    {
        blob = GameObject.FindGameObjectWithTag("Blob");
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.transform.tag == ("Blob"))
        {
            int scene = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(scene, LoadSceneMode.Single);
            Time.timeScale = 1;
        }
    }
}

