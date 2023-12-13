using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaidaScript : MonoBehaviour
{
    CheckPoint checkpointScript;
    [SerializeField] private Transform checkpoint1;
    [SerializeField] private Transform checkpoint2;
    int checkpoint = 0;
    private void Awake()
    {
        checkpointScript = FindObjectOfType<CheckPoint>();
    }
    private void Update()
    {
        Debug.Log(checkpoint);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            checkpointScript.SpawnCheckpoint(checkpoint,checkpoint1,checkpoint2);
        }
    }
    public int Getchekpoint()
    {
        return checkpoint;
    }
    public void Setchekpoint(int chekpoint)
    {
        checkpoint = chekpoint;
    }
}
