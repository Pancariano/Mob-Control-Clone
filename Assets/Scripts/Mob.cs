using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mob : MonoBehaviour
{
    public GameObject mobPrefab;
    public Transform mobPrefabTransform;

    float distance, radius;

    void Update()
    {
        MoveMob();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gate"))
        {
            var gate = other.GetComponent<Gate>();
            MakeMob(gate.gateValue);
        }
    }

    private void MoveMob()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);
    }

    private void MakeMob(int gateValue)
    {
        for (int i = 0; i < gateValue; i++)
        {
            Instantiate(mobPrefab, transform.position, Quaternion.identity);
        }
    }

    private void FormatMob()
    {

    }
}