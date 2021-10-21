using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    [CreateAssetMenuAttribute(menuName = "Weapon", fileName = "New Weapon", order = 51)]
    public class Weapon : ScriptableObject
    {
        [SerializeField] private string name;
        [SerializeField] private Sprite icon;
        [SerializeField] private int price;
        [SerializeField] private GameObject gun;
        [SerializeField] private GameObject bullet;
        [SerializeField] private bool isBuy = false;
        
        #region Property

        public string Name
        {
            get { return name; }
        }

        public Sprite Icon
        {
            get { return icon; }
        }

        public int Price
        {
            get { return price; }
        }

        public GameObject Gun
        {
            get { return gun; }
        }

        public GameObject Bullet
        {
            get { return bullet; }
        }

        public bool IsBuy
        {
            get { return isBuy; }
        }

        #endregion
        
        public void Buy()
        {
            isBuy = true;
        }
    }
}

