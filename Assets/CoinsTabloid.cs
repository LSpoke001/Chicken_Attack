using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinsTabloid : MonoBehaviour
{
    [SerializeField] private Money money;
    [SerializeField] private Text coinText;

    private void OnEnable()
    {
        money.ChangedMoney += ChangeCoinTabloid;
    }

    private void OnDisable()
    {
        money.ChangedMoney -= ChangeCoinTabloid;
    }

    private void ChangeCoinTabloid(int money)
    {
        coinText.text = money.ToString();
    }
}
    
