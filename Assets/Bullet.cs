using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float deathTime = 7f;
    private void Update()
    {
        Destroy(gameObject, deathTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
