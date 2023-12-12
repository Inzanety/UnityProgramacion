using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision) // si Colisiona con el collider
    {
        if (collision.CompareTag("Player")) //si el Player tiene el tag de "Player" colisiona con la caja de colision 
        {
            collision.GetComponent<RespawnPlayer>().ReachedCheckPoint(transform.position.x, transform.position.y); //se general el punto de spawn
            Debug.Log("choque"); //Esto es un debug en la consola para saber si colisiona
            GetComponent<Animator>().enabled = true;//Se enciende la animacion de bandera iddle 
        }
    }
}
