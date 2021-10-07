using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.iOS.Xcode;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private Button shopButton;
    [SerializeField] private Button exitButton;
    [SerializeField] private Button backButton;
    [SerializeField] private GameObject shopPanel;

    private void OnEnable()
    {
        shopButton.onClick.AddListener(TurnShopPanel);
        exitButton.onClick.AddListener(ExitFromGame);
        backButton.onClick.AddListener(BackToGame);
    }

    private void OnDestroy()
    {
        shopButton.onClick.RemoveListener(TurnShopPanel);
        exitButton.onClick.RemoveListener(ExitFromGame);
        backButton.onClick.RemoveListener(BackToGame);
    }

    private void TurnShopPanel()
    {
        shopPanel.SetActive(true);
        gameObject.SetActive(false);
    }

    private void BackToGame()
    {
        Time.timeScale = 1f;
        gameObject.SetActive(false);
    }
    private void ExitFromGame()
    {
        Application.Quit();
    }
}
