using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    public class WeaponsManager : MonoBehaviour
    {
        [SerializeField] private List<Weapon> weapons;
        [SerializeField] private Transform weaponPosition;

        private List<Weapon> weaponsInCash = new List<Weapon>();
        private GameObject currentWeapon;
        private int currentWeaponNum = 0;
        private IShootController shootController;

        public List<Weapon> Weapons
        {
            get => weapons;
        }

        public IShootController ShootController
        {
            get =>shootController;
        }

        private void Start()
        {
            weaponsInCash.Add(weapons[currentWeaponNum]);
            ChangeWeapon(weaponsInCash[currentWeaponNum]);
        }

        private void ChangeWeapon(Weapon weapon)
        {
            if(currentWeapon)
                Destroy(currentWeapon);
            currentWeapon = Instantiate(weapon.Gun, weaponPosition);
            shootController = currentWeapon.GetComponent<IShootController>();
            shootController.Instance(weapon.Bullet);
        }

        public void AddWeaponsInCash(Weapon weapon)
        {
            weaponsInCash.Add(weapon);
        }

        public void NextWeapon()
        {
            if (currentWeaponNum == weaponsInCash.Count - 1)
            {
                currentWeaponNum = 0;
            }
            else
            {
                currentWeaponNum++;
            }
            ChangeWeapon(weaponsInCash[currentWeaponNum]);
        }

        public void PreviousWeapon()
        {
            if (currentWeaponNum == 0)
            {
                currentWeaponNum = weaponsInCash.Count-1;
            }
            else
            {
                currentWeaponNum--;
            }
            ChangeWeapon(weaponsInCash[currentWeaponNum]);
        }
    }
}

