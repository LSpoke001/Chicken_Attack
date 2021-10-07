using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{
    [SerializeField] private List<Weapon> weapons;
    [SerializeField] private WeaponShoot pleyersWeapon;
    [SerializeField] private WeaponView tmpWeapon;
    [SerializeField] private GameObject itemConteiner;
    [SerializeField] private Button exitButton;

    private Money money;

    private void OnEnable()
    {
        exitButton.onClick.AddListener(ExitFromShop);
    }

    private void OnDisable()
    {
        exitButton.onClick.RemoveListener(ExitFromShop);
    }

    private void Start()
    {
        for (int i = 0; i < weapons.Count; i++)
        {
            AddItem(weapons[i]);
        }

        money = pleyersWeapon.gameObject.GetComponent<Money>();
    }

    private void AddItem(Weapon weapon)
    {
        var view = Instantiate(tmpWeapon, itemConteiner.transform);
        view.BuyButtonClick += OnSellButtonClick;
        view.Render(weapon);
    }

    private void OnSellButtonClick(Weapon weapon, WeaponView view)
    {
        TrySellWeapon(weapon, view);
    }

    private void TrySellWeapon(Weapon weapon, WeaponView view)
    {
        if (weapon.price <= money.countMoney)
        {
            money.RemoveMoney(weapon.price);
            pleyersWeapon.BuyWeapon(weapon);
            weapon.Buy();
            view.BuyButtonClick -= OnSellButtonClick;
        }
    }

    private void ExitFromShop()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
}
