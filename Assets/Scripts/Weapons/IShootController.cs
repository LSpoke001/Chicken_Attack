using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    public interface IShootController 
    {
        void Instance(GameObject newBullet);

        public void Shoot();
    }
}

