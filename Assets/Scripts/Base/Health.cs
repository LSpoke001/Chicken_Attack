using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ChickenAttack
{
    public abstract class Health : MonoBehaviour, IHealth
    {
        [SerializeField]protected int healthValue;
        public event UnityAction Died;
        public event UnityAction<int> CheangeHealth;

        private void Start()
        {
            CheangeHealth?.Invoke(healthValue);
        }

        public int HealthValue
        {
            get => healthValue;
        }
        public virtual int HealthChange(int value)
        {
            healthValue -= value;
            CheangeHealth?.Invoke(healthValue);
            if (healthValue <= 0)
            {
                Died?.Invoke();
                return 0;
            }
            return healthValue;
        }
    }
}

