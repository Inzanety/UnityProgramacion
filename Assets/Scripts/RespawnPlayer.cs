using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    private Transform puntoInicio;

    private void Awake()
    {
        puntoInicio = GameObject.FindGameObjectWithTag("PuntoInicioPlayer").transform;
        transform.position = puntoInicio.position;
    } 
}
