using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    [SerializeField] float speed;
    bool hasTarget;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        move();
    }

    void move()
    {
        if(!hasTarget) { 
            rb.velocity = Vector3.forward;
        }
    }
}