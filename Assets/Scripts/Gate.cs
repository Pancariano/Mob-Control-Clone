using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Runtime.InteropServices.WindowsRuntime;

public class Gate : MonoBehaviour
{
    public TMP_Text gateText;
    public int gateValue;
    public GameObject mob;

    void Awake()
    {
        SetGateValue();
        gateText.text = $"x{gateValue}";
    }

    private void SetGateValue()
    {
        gateValue = Random.Range(2, 6);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mob")
        {
            for (int i = 0; i < gateValue - 1; i++)
            {
                if (mob != null)
                {
                    Instantiate(mob, other.transform.position + new Vector3(Random.Range(-0.5f, 0.8f), 0, Random.Range(.5f, .8f)), Quaternion.identity);
                }
            }
        }
    }
}