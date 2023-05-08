using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem.LowLevel;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject enemySpawner;
    public bool lose;
    public TMP_Text health;
    public int baseHealth;
    

    void Start()
    {      
        baseHealth = 10;
        InvokeRepeating(nameof(SpawnEnemy), 0f, 5f);
    }

    private void Update()
    {
        health.text = baseHealth.ToString();
    }

    private void SpawnEnemy()
    {
        if (!lose)
        {
            Instantiate(enemy, enemySpawner.transform.position, enemySpawner.transform.rotation);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Mob")
        {
            Destroy(other.gameObject);
            if (baseHealth > 0)
            {
                baseHealth--;
            }
            if ( baseHealth == 0)
            {
                LevelManager.win = true;
            }
        }
    }
}