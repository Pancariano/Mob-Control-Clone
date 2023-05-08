using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    [SerializeField] float speed = 3;
    bool hasTarget;
    Rigidbody rb;
    string targetName;
    float detectionDistance;
    GameObject target;
    

    private void Start()
    {
        detectionDistance = 30f;
        targetName = "targetCannon";
        rb = GetComponent<Rigidbody>();       
    }

    private void Update()
    {
        Move();       
    }

    void Move()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetName);
        if (targetObject != null)
        {
            float distance = Vector3.Distance(transform.position, targetObject.transform.position);
            if (distance < detectionDistance)
            {
                hasTarget = true;
                target = targetObject;
            }
        }

        if (hasTarget)
        {
            Vector3 direction = (target.transform.position - transform.position).normalized;
            rb.velocity = direction * speed;
        }

        else if (!hasTarget)
        {
            rb.velocity = Vector3.forward;
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "targetCannon")
        {
            GameHandler.score++;          
        }
    }
}