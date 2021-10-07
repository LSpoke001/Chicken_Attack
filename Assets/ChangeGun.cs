using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeGun : MonoBehaviour
{
    [SerializeField] private Button next;
    [SerializeField] private Button previous;
    [SerializeField] private WeaponShoot weaponShoot;

    private void OnEnable()
    {
        next.onClick.AddListener(Next);
        previous.onClick.AddListener(Previous);
    }

    private void OnDisable()
    {
        next.onClick.RemoveListener(Next);
        previous.onClick.RemoveListener(Previous);
    }

    private void Next()
    {
        weaponShoot.NextWeapon();
    }

    private void Previous()
    {
        weaponShoot.PreviousWeapon();
    }
}
