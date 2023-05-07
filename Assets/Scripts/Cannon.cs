using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject mobPrefab;
    public Transform mobSpawn;
    public float fireRate = 0.5f;
    private bool shooting = false;
    public float speed = 5f;
    private bool isMoving = false;

    void Update()
    {
        ShootMob();
        MovePlayer();
    }

    private void ShootMob()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shooting = true;
            StartCoroutine(SpawnMob());
        }
        if (Input.GetMouseButtonUp(0))
        {
            shooting = false;
        }
    }

    IEnumerator SpawnMob()
    {
        while (shooting)
        {
            GameObject mob = Instantiate(mobPrefab, mobSpawn.position, mobSpawn.rotation);
            yield return new WaitForSeconds(fireRate);
        }
    }

    void MovePlayer()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isMoving = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            isMoving = false;
        }

        if (isMoving)
        {
            float moveX = Input.GetAxis("Mouse X") * speed * Time.deltaTime;
            transform.Translate(new Vector3(moveX, 0, 0));
        }
    }
}
