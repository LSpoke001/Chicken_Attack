using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace ChickenAttack.UI
{
    public class ChangeWeapon : MonoBehaviour
    {
        [Inject] private MainController controller;
        [SerializeField] private Button next;
        [SerializeField] private Button previous;

        private WeaponsManager weaponsManager;
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

        private void Start()
        {
            weaponsManager = controller.WeaponsManager;
        }

        private void Next()
        {
           weaponsManager.NextWeapon();
        }

        private void Previous()
        {
           weaponsManager.PreviousWeapon();
        }
    }
}

