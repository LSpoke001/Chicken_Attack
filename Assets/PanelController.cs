using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject shopPanel;
    [SerializeField] private Button menuButton;

    private void Awake()
    {
        menuPanel.SetActive(false);
        shopPanel.SetActive(false);
    }

    private void OnEnable()
    {
        menuButton.onClick.AddListener(TurnMenuPanel);
    }

    private void OnDestroy()
    {
        menuButton.onClick.RemoveListener(TurnMenuPanel);
    }

    private void TurnMenuPanel()
    {
        Time.timeScale = 0f;
        menuPanel.SetActive(true);
    }
}
