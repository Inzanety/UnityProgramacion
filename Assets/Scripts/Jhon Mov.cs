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
    private int Life = 5;

    [Header("Sonidos")] //Parametro para que se muestre en el Inspector, hace que se vea mas ordenado
    [SerializeField] GameObject SaltoJhon; //Es el Objeto que se va a crear generando el sonido 
    [SerializeField] GameObject DisparoJhon;
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
            Instantiate (SaltoJhon);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
            Instantiate(DisparoJhon);
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

    public void Hit()
    {
        Life = Life - 1;
        if (Life == 0) Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D collision) //Si Jhon colisiona con:
    {
        if (collision.gameObject.CompareTag("Manzana")) //Si colisiona con la manzana se ejecuta el codigo anterior
        {
            VidaApple.ItemManzana(collision, Life);
        }
        if (collision.gameObject.CompareTag("Platano"))// Si colisiona con el Platano
        {
            VidaApple.ItemPlatano(collision, Life);
        }
        if (collision.gameObject.CompareTag("Kiwi"))//Si colisiona con el Kiwi
        {
            VidaApple.ItemKiwi(collision, Life);

        }
    }
}
