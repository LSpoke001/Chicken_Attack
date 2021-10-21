using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace ChickenAttack
{
    public class Money : MonoBehaviour
    {
        [SerializeField] private int countMoney = 0;
        public event UnityAction<int> ChangedMoney;

        public int Count
        {
            get => countMoney;
        }

        private void Start()
        {
            ChangedMoney?.Invoke(countMoney);
        }

        public void AddMoney(int money)
        {
            countMoney += money;
            ChangedMoney?.Invoke(countMoney);
        }

        public void RemoveMoney(int money)
        {
            countMoney -= money;
            ChangedMoney?.Invoke(countMoney);
        }
    }

}
