using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    public class PlayerController : BaseObject
    {
        public void PlayerRotate(float verticalRotate, float horizontalRotate)
        {
            GetTransform.rotation = Quaternion.Euler(verticalRotate, -horizontalRotate, 0f);
        }
    }
}

