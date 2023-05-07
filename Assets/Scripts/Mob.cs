using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    void Update()
    {
        MoveMob();
    }

    private void MoveMob()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
