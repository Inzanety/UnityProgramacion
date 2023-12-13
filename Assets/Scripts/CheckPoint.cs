using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{  
    private int checkpoint;
    CaidaScript Caidascript;
    private void Start()
    {
        Caidascript = FindObjectOfType<CaidaScript>();
    }
    private void Update()
    {
        checkpoint = Caidascript.Getchekpoint();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (checkpoint  < 4)
            {
                checkpoint ++;
                Caidascript.Setchekpoint(checkpoint);
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
                
            }                     
        }
    }
    
    public void SpawnCheckpoint(int valor,Transform checkpoint,Transform checkpoint2, Transform checkpoint3, Transform checkpoint4)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if(valor == 0)
        {
            player.transform.position = GameObject.FindGameObjectWithTag("PuntoInicioPlayer").transform.position;
        }
        else if (valor == 1) {
            player.transform.position = checkpoint.position;
        }
        else if (valor == 2)
        {
            player.transform.position = checkpoint2.position;
        }
        else if(valor == 3)
        {
            player.transform.position = checkpoint3.position;
        }
        else if(valor == 4)
        {
            player.transform.position = checkpoint4.position;
        }

    }
}
