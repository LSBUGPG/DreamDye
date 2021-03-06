﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawLine : MonoBehaviour
{
    public GameObject linePrefab;
    public GameObject currentLine;
    public LineRenderer lineRenderer;
        public EdgeCollider2D edgeCollider;
    public List<Vector2> fingerPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            createLine();
        }
        if(Input.GetMouseButton(0))
        {
            Vector2 tempFingerPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(tempFingerPos, fingerPos[fingerPos.Count - 1]) > .1f)
            {
                updateLine(tempFingerPos);
            }
        }

    }
    void createLine()
    {
        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
       lineRenderer = currentLine.GetComponent<LineRenderer>();
        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
        fingerPos.Clear();
        fingerPos.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        fingerPos.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        lineRenderer.SetPosition(0, fingerPos[0]);
        lineRenderer.SetPosition(1, fingerPos[1]);
        edgeCollider.points = fingerPos.ToArray();

    }
    void updateLine(Vector2 newFingerPos)
    {
        fingerPos.Add(newFingerPos);
        lineRenderer.positionCount++;
        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);
        edgeCollider.points = fingerPos.ToArray();
    }
}
