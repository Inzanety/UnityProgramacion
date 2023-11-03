using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeVida : MonoBehaviour
{
    public float TempodeVida; //Aquí determinaremos cuantos segundos queremos

    private void Start()
    {
        Destroy(gameObject,TempodeVida); //Aqui hacemos que el item se destruya al pasar el tempo de vida del Item.
    }


}
