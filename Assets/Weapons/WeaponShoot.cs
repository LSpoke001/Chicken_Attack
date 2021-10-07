using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class WeaponShoot : MonoBehaviour
{
    public GameObject bulletPref;
    public List<Weapon> weaponList;
    public Transform gunPoint;
    public Button button;

    private GameObject currentGun;
    private int currentWeaponNum = 0;
    
    private void Awake()
    {
        ChangeWeapon(weaponList[currentWeaponNum]);
    }
    private float speed = 1000f;
    private void OnEnable()
    {
        button.onClick.AddListener(ShootGun);
    }
    private void OnDisable()
    {
        button.onClick.RemoveListener(ShootGun);
    }
    private void ShootGun()
    {
        currentGun.GetComponent<BulletCreate>().Shoot(bulletPref);
    }

    public void BuyWeapon(Weapon weapon)
    {
        weaponList.Add(weapon);
    }

    public void NextWeapon()
    {
        if (currentWeaponNum == weaponList.Count - 1)
        {
            currentWeaponNum = 0;
        }
        else
        {
            currentWeaponNum++;
        }
        ChangeWeapon(weaponList[currentWeaponNum]);
    }

    public void PreviousWeapon()
    {
        if (currentWeaponNum == 0)
        {
            currentWeaponNum = weaponList.Count-1;
        }
        else
        {
            currentWeaponNum--;
        }
        ChangeWeapon(weaponList[currentWeaponNum]);
    }

    private void ChangeWeapon(Weapon weaponChange)
    {
        if(currentGun!=null)
            Destroy(currentGun);
        currentGun = Instantiate(weaponChange.gun, gunPoint);
    }
}
