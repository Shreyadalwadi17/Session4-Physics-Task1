using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballshoot : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    [HideInInspector] public Vector3 ballPosition;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Shoot(Vector3 hitpoint)
    {
        Rigidbody rb1 = GetComponent<Rigidbody>();
        rb1.AddForce((hitpoint - transform.position).normalized * speed);
    }
}

