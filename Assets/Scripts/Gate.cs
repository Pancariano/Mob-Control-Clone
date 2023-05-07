using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System.Runtime.InteropServices.WindowsRuntime;

public class Gate : MonoBehaviour
{
    public TMP_Text gateText;
    string[] gateType = {"Sum", "Multiply"};
    string gateOperator;
    int gateValue;

    void Awake()
    {
        gateText.text = $"{SetGateOperator(gateOperator)}{SetGateValue(gateValue)}";
    }

    private string SetGateOperator(string textOperator)
    {
        string gateOperator = gateType[Random.Range(0, gateType.Length)];

        if (gateOperator == "Sum")
        {
            return "+";
        }
        else
        {
            return "x";
        }
    }

    private int SetGateValue(int gateValue)
    {
        gateValue = Random.Range(1, 6);
        return gateValue;
    }
}