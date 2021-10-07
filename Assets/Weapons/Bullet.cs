using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    private float deathTime = 7f;
    private Money money;
    private int moneyForChiken = 1;
    
    private void Start()
    {
        Destroy(gameObject, deathTime);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Chicken>())
        {
            money = GetComponentInParent<Money>();
            money.AddMoney(moneyForChiken);
        }
        Destroy(gameObject);
    }
}
