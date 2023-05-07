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

    void Awake()
    {      
        SetGateValue();
        gateText.text = $"x{gateValue}";
    }

    private void SetGateValue()
    {
        gateValue = Random.Range(1, 6);
    }
}