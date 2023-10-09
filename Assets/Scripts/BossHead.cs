using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHead : MonoBehaviour
{
    public GameObject Jhon;
    private float LastShoot;
    public GameObject BulletEnemy;  
    private int Life = 5;
    public GameObject Bossbody;

    private void Update()
    {
        if (Jhon == null) return;

        Vector3 direction = Jhon.transform.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(Jhon.transform.position.x - transform.position.x);

        if (distance < 1.0f && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;

        }


    }
    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;
        GameObject bullet = Instantiate(BulletEnemy, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletEnemyScript>().SetDirection(direction);

    }
    public void Hit()
    {
        Life = Life - 1;
        if (Life == 0) Destroy(gameObject);
    }
}
