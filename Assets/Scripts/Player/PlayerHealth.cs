using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    public class PlayerHealth : Health
    {
        private void Awake()
        {
            healthValue = 3;
        }
    }
}

