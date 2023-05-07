using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        MoveMob();
    }

    private void MoveMob()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }
}
