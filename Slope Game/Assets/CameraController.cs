using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CameraController : MonoBehaviour{
    public Transform Sphere;
    public float distanceFromObject = 7f;
    void Update()
    {

        Vector3 lookOnObject = Sphere.position - transform.position;
        lookOnObject = Sphere.position - transform.position;
        transform.forward = lookOnObject.normalized;
        Vector3 SphereLastPosition;
        SphereLastPosition = Sphere.position - lookOnObject.normalized * distanceFromObject;
        SphereLastPosition.y = Sphere.position.y + distanceFromObject / 2;
        transform.position = SphereLastPosition;
        
    }
}
