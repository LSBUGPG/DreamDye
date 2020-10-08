using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform currentFollow;
    public Camera cinemachine;

   


    public Transform follow1;

    public Transform follow2;

    public Transform follow3;



    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        CinemachineVirtualCamera cinemachineVirtualCamera = this.gameObject.GetComponent<CinemachineVirtualCamera>();
        if (follow1.GetComponent<roomExit>().leftRoom1 == false && follow1.GetComponent<roomExit>().enteredRoom2 == false)
        {
            cinemachineVirtualCamera.m_Follow = follow1;
        }
       

        if (follow1.GetComponent<roomExit>().leftRoom1 == true && follow1.GetComponent<roomExit>().enteredRoom2 == true)
        {
            
            cinemachineVirtualCamera.m_Follow = follow2;

        }       
        if (follow2.GetComponent<roomExit>().leftRoom2 == true && follow2.GetComponent<roomExit>().enteredRoom3 == true)
        {

            cinemachineVirtualCamera.m_Follow = follow3;

        }
      
    }
}
