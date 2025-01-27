using System;
using UnityEngine;
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.right * 500);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with " + collision.gameObject.name);
    }
}   