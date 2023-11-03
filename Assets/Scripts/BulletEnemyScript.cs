using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyScript : MonoBehaviour
{
    public float Speed; //Variable de Velocidad de disparo
    private Rigidbody2D Rigidbody2D; 
    private Vector2 Direction; //Vectores de direcciones
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }
    public void SetDirection(Vector2 direction) //Para darle direccion a la bala
    {
        Direction = direction;
    }
    public void DestroyBullet() //Para que la bala se destruya y no se generen infinitas
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision) //Cuando colisiona con Jhon
    {
        JhonMov Jhon = collision.GetComponent<JhonMov>(); //llamamos a "Jhon" para que se reconozca en este codigo
       
        if (Jhon != null) //Si "jhon" esta vivo
        {
            Jhon.Hit(); //Funcion Hit creada en "jhon mov"
            DestroyBullet(); //Se destruye la bala
        }
        
    }
}
