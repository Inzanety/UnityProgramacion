using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 anteriorPosicionCamara;
    [SerializeField] private float velocidadparalaxx;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        anteriorPosicionCamara = cameraTransform.position;
    }
    void LateUpdate()
    {
        float deltaX = (cameraTransform.position.x - anteriorPosicionCamara.x) * velocidadparalaxx;
        transform.Translate(new Vector3(deltaX, 0, 0));
        anteriorPosicionCamara = cameraTransform.position;
    }
}