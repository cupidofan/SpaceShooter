using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    private float speed = 5f;
    private void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Random.insideUnitSphere * speed;
    }
}
