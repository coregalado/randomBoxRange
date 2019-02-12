using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheetController : MonoBehaviour {
    public float power;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        rb.AddTorque(transform.up * power * h);
    }
}
