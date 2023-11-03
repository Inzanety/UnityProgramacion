using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaApple : MonoBehaviour
{

    public static void ItemManzana(Collision2D collision,int Life)
    {
        if (Life < 5 )
        {
            Life += 3;
            Destroy( collision.gameObject );
        
        }
        else if  (Life >= 5 ) 
        {
            Life = 5;
            Destroy( collision.gameObject );
        }
    }
    public static void ItemPlatano(Collision2D collision, int Life)
    {
        if (Life < 5)
        {
            Life += 1;
            Destroy(collision.gameObject);

        }
        else if (Life >= 5)
        {
            Life = 5;
            Destroy(collision.gameObject);
        }
    }
    public static void ItemKiwi(Collision2D collision, int Life)
    {
        if (Life < 5)
        {
            Life += 2;
            Destroy(collision.gameObject);

        }
        else if (Life >= 5)
        {
            Life = 5;
            Destroy(collision.gameObject);
        }
    }
}

