using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GruntScript : MonoBehaviour
{
    public GameObject Jhon;
    private float LastShoot;
    public GameObject BulletEnemy;
    private int Life = 2;

    private void Update()
    {
        if (Jhon == null) return; //Funcion para rastrear a Jhon

        Vector3 direction = Jhon.transform.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
        else transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);

        float distance = Mathf.Abs(Jhon.transform.position.x - transform.position.x); //calculo para que tenga una distancia de disparo y no dispare de lejos

        if (distance < 1.0f && Time.time > LastShoot + 1.5f) //Le damos un tiempo y una condicion al disparo
        {
            Shoot();
            LastShoot = Time.time;

        }


    }
    private void Shoot() //Funcion para que dispare 
    {
        
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;
        GameObject bullet = Instantiate(BulletEnemy, transform.position + direction * 0.1f, Quaternion.identity); //Crea el item BulletEnemy para que dispare
        bullet.GetComponent<BulletEnemyScript>().SetDirection(direction);
    }
    public void Hit()//Funcion para restar uno de vida al grunt en caso de que "jhon" le da una bala
    {
        Life = Life - 1;
        if (Life == 0) Destroy(gameObject);
    }

}
