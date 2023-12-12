using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformas : MonoBehaviour
{
    public float speed = 0.5f; // la velocidad en que se moverá
    private float waitTime; //el tiempo de espera
    public Transform[] moveSpots; //el lugar por donde se moverá la plataforma
    public float starWaitTime = 2; //el timepo de inicio de la plataforma
    private int i = 0;


        private void Start()
    {
        waitTime = starWaitTime; 

    }

    private void Update()
    {
        transform.position = Vector2 .MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, moveSpots[i].transform.position)< 0.1f)
        {
          if (waitTime <= 0)
            {
            
                if (moveSpots[i] != moveSpots[moveSpots.Length-1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
                waitTime = starWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            } 


        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(transform);
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(null);
    }
}
