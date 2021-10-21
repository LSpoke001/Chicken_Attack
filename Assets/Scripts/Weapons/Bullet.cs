using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    public class Bullet : BaseObject
    {
        [SerializeField]private int damage = 2;
        private float timeLife = 5f;
        private void Start()
        {
            Destroy(GetGameObject, timeLife);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.TryGetComponent(out IHealth character))
            {
                character.HealthChange(damage);
            }
            Destroy(GetGameObject);
        }
    }
}

