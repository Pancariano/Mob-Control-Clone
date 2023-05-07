using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject mobPrefab;
    public Transform mobSpawn;
    public float fireRate = 0.5f;
    private bool shooting = false;

    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shooting = true;
            StartCoroutine(SpawnBullet());
        }
        if (Input.GetMouseButtonUp(0))
        {
            shooting = false;
        }
    }

    IEnumerator SpawnBullet()
    {
        while (shooting)
        {
            GameObject mob = Instantiate(mobPrefab, mobSpawn.position, mobSpawn.rotation);           
            yield return new WaitForSeconds(fireRate);
        }
    }
}
