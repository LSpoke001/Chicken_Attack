using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChikenHealth : Health
{
    public int chikenHealthCount = 1;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<Bullet>())
        {
            chikenHealthCount = HealthChange(chikenHealthCount);
            if (chikenHealthCount <= 0)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
