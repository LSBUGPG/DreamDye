using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public Canvas pauseMenu;
    public bool paused; 

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && paused == false)
        {
            pauseMenu.enabled = true;
            paused = true;
            Time.timeScale = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && paused == true)
        {
            paused = false;
            pauseMenu.enabled = false;
            Time.timeScale = 1;

        }
    }
}
