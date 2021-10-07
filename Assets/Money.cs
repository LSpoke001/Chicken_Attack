using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Money : MonoBehaviour
{
    public int countMoney = 0;
    public event UnityAction<int> ChangedMoney;

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
