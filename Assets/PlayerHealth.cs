using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : Health
{
    public int healthCount = 3;
    public event UnityAction<int> HealthChanged;
    public event UnityAction Dead;

    private void Awake()
    {
        HealthChanged?.Invoke(healthCount);
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.TryGetComponent(out Chicken chicken))
        {
            healthCount = HealthChange(healthCount);
            HealthChanged?.Invoke(healthCount);
            if (healthCount <= 0)
            {
                Dead?.Invoke();
            }
            chicken.gameObject.SetActive(false);
        }
    }
}
