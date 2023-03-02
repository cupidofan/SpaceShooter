using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 move = new Vector3(0, 1, 0);
        rb.velocity = move*speed;
    }

}
