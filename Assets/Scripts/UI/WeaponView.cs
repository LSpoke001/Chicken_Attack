using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ChickenAttack.UI
{
    public class WeaponView : MonoBehaviour
    {
        [SerializeField] private Text label;
        [SerializeField] private Text price;
        [SerializeField] private Image icon;
        [SerializeField] private Button buyButton;
        [SerializeField] private Sprite buyIcon;

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
            price.text = weapon.Price.ToString();
            icon.sprite = weapon.Icon;
        }

        public void TryLockWeapon()
        {
            if (this.weapon.IsBuy)
            {
                buyButton.interactable = false;
                icon.sprite = buyIcon;
            }
        }

        private void OnButtonClick()
        {
            BuyButtonClick?.Invoke(weapon, this);
            //TryLockWeapon();
        }
    }
}
