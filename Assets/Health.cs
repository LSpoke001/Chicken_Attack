using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    protected int HealthChange(int healthValue)
    {
        healthValue--;
        if (healthValue <= 0)
        {
            return 0;
        }
        return healthValue;
    }
}
