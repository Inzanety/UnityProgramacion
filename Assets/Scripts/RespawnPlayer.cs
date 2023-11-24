using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RespawnPlayer : MonoBehaviour
{
    private float checkPointPositionX, checkPointPositionY;
    void Start()
    {
        PlayerRespawn();
    }

    // Update is called once per frame
    public void ReachedCheckPoint(float x, float y)
    {
        Debug.Log("Se guardo coordenadas");
        PlayerPrefs.SetFloat("checkPointPositionX",x);
        PlayerPrefs.SetFloat("checkPointPositionY", y);
    }
    public void PlayerRespawn()
    {
        float checkpointX = PlayerPrefs.GetFloat("checkPointPositionX");
        float checkpointY = PlayerPrefs.GetFloat("checkPointPositionY");

        transform.position = new Vector2(checkpointX, checkpointY);

        gameObject.SetActive(true);
    }
}
