using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{

    private Vector3 posA;
    private Vector3 posB;
    private Vector3 NextPos;


    [SerializeField]
    private float Speed;
    [SerializeField]
    private Transform childTransform;
    [SerializeField]
    private Transform transformB;

    // Use this for initialization
    void Start()
    {
        posA = childTransform.transform.position;
        posB = transformB.transform.position;
        NextPos = posB;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        childTransform.transform.position = Vector3.MoveTowards(childTransform.transform.position, NextPos, Speed * Time.deltaTime);

        if (Vector3.Distance(childTransform.transform.position, NextPos) <= 0.1)
        {

            ChangeDestination();
        }
    }

    private void ChangeDestination()
    {
        NextPos = NextPos != posA ? posA : posB;

    }

 
}