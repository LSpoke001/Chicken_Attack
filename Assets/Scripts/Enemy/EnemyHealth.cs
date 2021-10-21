using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    public class EnemyHealth : Health
    {
        private Money money;
        private int award = 1;
        private int tmpHealth;
        private void Awake()
        {
            money = FindObjectOfType<Money>();
            tmpHealth = healthValue;
            this.Died += SetActiveEnemy;
        }

        private void OnDestroy()
        {
            this.Died -= SetActiveEnemy;
        }

        private void SetActiveEnemy()
        {
            money.AddMoney(award);
            this.gameObject.SetActive(false);
            healthValue = tmpHealth;
        }
    }
}

