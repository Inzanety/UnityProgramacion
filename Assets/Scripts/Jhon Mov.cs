using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JhonMov : MonoBehaviour
{
    public float Speed;
    public float JumpForce;

    private Rigidbody2D Fisicas;
    private float Horizontal;


    void Start()
    {
        Fisicas = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();

        }

    }
    private void FixedUpdate()
    {
        Fisicas.velocity = new Vector2(Horizontal, Fisicas.velocity.y);
    }

    private void Jump()
    {
        Fisicas.AddForce(Vector2.up*JumpForce); 
    }

    
   

}
