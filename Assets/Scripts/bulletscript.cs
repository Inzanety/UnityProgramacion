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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        JhonMov Jhon = collision.collider.GetComponent<JhonMov>();
        GruntScript Grunt = collision.collider.GetComponent<GruntScript>();
        if (Jhon != null)
        {
            Jhon.Hit();

        }
        if (Grunt != null)
        {
            Grunt.Hit();
        }
        DestroyBullet();
    }
}
