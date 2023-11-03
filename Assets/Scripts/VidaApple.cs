using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaApple : MonoBehaviour
{

    public static void ItemManzana(Collision2D collision,int Life) //Cada vez que el jugador colisione
    {
        if (Life < 5 ) //Si Life es menor que 5 entonces se ejecuta:
        {
            Life += 3; //Se le suma 3 puntos de vida con la Manzana al jugador
            Destroy( collision.gameObject ); //Se destruye la manzana una vez el jugador entra en contacto
        
        }
        else if  (Life >= 5 ) // Si Life es mayor o igual a 5 se ejecura: 
        {
            Life = 5; //Se queda igual para no curar
            Destroy( collision.gameObject ); // Se destruye
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

