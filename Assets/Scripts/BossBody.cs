using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BossBody : MonoBehaviour
{
    public GameObject BossHead;
    public GameObject Bossbody;

    private void Update()
    {
        if (BossHead == null)
            Destroy(gameObject);
    }
}
