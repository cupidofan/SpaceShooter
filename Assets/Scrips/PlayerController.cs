using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;


public class Bound
{
    public float xMax = 6.5f;
    public float xMin = -6.5f;
    public float yMax = 10f;
    public float yMin = -10f;
}
public class PlayerController : MonoBehaviour
{


    public float speed = 10f;
    Bound bound = new Bound();
    public void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical"); 
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 move = new Vector3(h, v, 0f);
        rb.velocity = move * speed;
        rb.position = new Vector3(
            Mathf.Clamp(rb.position.x, bound.xMin, bound.xMax),
            Mathf.Clamp(rb.position.y, bound.yMin, bound.yMax),
            0f);
    }

}
