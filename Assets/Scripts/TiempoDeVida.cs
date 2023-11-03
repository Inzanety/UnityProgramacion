using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeVida : MonoBehaviour
{
    public float TempodeVida;

    private void Start()
    {
        Destroy(gameObject,TempodeVida);
    }


}
