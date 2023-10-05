using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JhonMov : MonoBehaviour
{
    public GameObject Bulletprefab;
    public float Speed;
    public float JumpForce;
     
    private Rigidbody2D Fisicas;
    private Animator Animator;
    private float Horizontal;
    private bool Grounded;


    void Start()
    {
        Animator = GetComponent<Animator>();
        Fisicas = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        Animator.SetBool("running", Horizontal != 0.0f);

        if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f); 
        else if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        
        

        Debug.DrawRay(transform.position, Vector3.down * 0.1f, Color.red);
        if (Physics2D.Raycast(transform.position, Vector3.down,0.1f))
        {
            Grounded = true;
        }
        else
        {
            Grounded = false;
        }

        if (Input.GetKeyDown(KeyCode.W)&&Grounded)
        {
            Jump();

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
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

    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;
        GameObject bullet = Instantiate(Bulletprefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<bulletscript>().SetDirection(direction);
    }
}
