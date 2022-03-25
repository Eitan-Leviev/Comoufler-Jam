using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShapes : MonoBehaviour
{
    private void Awake()
    {
        print("move shapes awake");
    }

    [SerializeField] private GameObject rotator;
    // [SerializeField] private GameObject rotateTrianglePivot;
    
    [SerializeField] private float rotationSpeed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        rotator.transform.Rotate(new Vector3(0, 0, -1 * rotationSpeed * Time.deltaTime), Space.Self);
        // rotateTrianglePivot.transform.Rotate(new Vector3(0, 0, -1 * rotationSpeed), Space.Self);
    }
}