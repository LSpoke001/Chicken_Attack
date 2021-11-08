using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Zenject;

namespace ChickenAttack.UI
{
    public class Shop : MonoBehaviour
    {
        [Inject] private MainController controller;
        [SerializeField] private WeaponView tmpWeapon;
        [SerializeField] private GameObject itemConteiner;
        [SerializeField] private Button exitButton;
        [SerializeField] private Money money;
        
        private PanelController panelController;
        private WeaponsManager weaponsManager;
        
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
            panelController = GetComponentInParent<PanelController>();
            weaponsManager = controller.WeaponsManager;
            for (int i = 0; i < weaponsManager.Weapons.Count; i++)
            {
                AddItem(weaponsManager.Weapons[i]);
            }
        }

        private void AddItem(Weapon weapon)
        {
            var view = Instantiate(tmpWeapon, itemConteiner.transform);
            view.BuyButtonClick += OnSellButtonClick;
            view.Render(weapon);
        }

        private void OnSellButtonClick(Weapon weapon, WeaponView view)
        {
            if (weapon.Price <= money.Count && !weapon.IsBuy)
            {
                money.RemoveMoney(weapon.Price);
                weapon.Buy();
                weaponsManager.AddWeaponsInCash(weapon);
                view.TryLockWeapon();
                view.BuyButtonClick -= OnSellButtonClick;
            }
        }

        private void ExitFromShop()
        {
            Time.timeScale = 1f;
            panelController.SetPanel(PanelController.Panel.None);
        }
    }
}

