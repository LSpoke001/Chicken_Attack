using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class WeaponView : MonoBehaviour
{
    [SerializeField] private Text label;
    [SerializeField] private Text price;
    [SerializeField] private Image icon;
    [SerializeField] private Button buyButton;

    public event UnityAction<Weapon, WeaponView> BuyButtonClick;

    private void OnEnable()
    {
        buyButton.onClick.AddListener(OnButtonClick);
    }

    private void OnDisable()
    {
        buyButton.onClick.RemoveListener(OnButtonClick);
    }

    private Weapon weapon;
    public void Render(Weapon weapon)
    {
        this.weapon = weapon;

        label.text = weapon.name;
        price.text = weapon.price.ToString();
        icon.sprite = weapon.icon;
    }

    private void TryLockWeapon()
    {
        if (weapon.isBuy)
        {
            buyButton.interactable = false;
        }
    }
    private void OnButtonClick()
    {
        BuyButtonClick?.Invoke(weapon, this);
    }
}
