using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Gate : MonoBehaviour
{
    public TMP_Text gateText;

    private void Awake()
    {
        
    }
   
    void Start()
    {

    }
    
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gate"))
        {

        }
    }
}