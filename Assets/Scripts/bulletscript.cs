using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletscript : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>(); 
    }

 
    void Update()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }
    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }
    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        JhonMov Jhon = collision.GetComponent<JhonMov>();
        GruntScript Grunt = collision.GetComponent<GruntScript>();
        BossHead BossHead = collision.GetComponent<BossHead>();
        TurretScript Torreta = collision.GetComponent<TurretScript>();
        if (Jhon != null)
        {
            Jhon.Hit();

        }
        if (Grunt != null)
        {
            Grunt.Hit();
        }
        if (BossHead != null)
        {
            BossHead.Hit();
        }
        if (Torreta != null)
        {
            Torreta.Hit();
        }
        DestroyBullet();
    }
   
}
