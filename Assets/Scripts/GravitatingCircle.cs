using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravitatingCircle : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;
    public float factor = 1.0f;
    private bool passed = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -20)
        {
            rb.useGravity = false;
            if(!passed)
            {
                rb.velocity = Vector3.zero;
                passed = true;
            }
            rb.AddForce(9.81f * Vector3.up * factor);
        }
        else if(transform.position.y > 20)
        {
            rb.velocity = Vector3.zero;
            rb.useGravity = true;
            passed = false;
        }
    }
}
