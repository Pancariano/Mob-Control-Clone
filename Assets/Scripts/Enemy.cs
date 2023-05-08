using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Move();
    }

    void Move()
    {
        rb.velocity = -Vector3.forward;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Mob")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}