using System;
using System.Collections;
using System.Collections.Generic;
using ChickenAttack.UI;
using UnityEditor.iOS.Xcode;
using UnityEngine;
using UnityEngine.UI;

namespace ChickenAttack.UI
{
    public class MenuPanel : MonoBehaviour
    {
        [SerializeField] private Button shopButton;
        [SerializeField] private Button exitButton;
        [SerializeField] private Button backButton;

        private PanelController panelController;

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

        private void Start()
        {
            panelController = GetComponentInParent<PanelController>();
        }

        private void TurnShopPanel()
        {
            panelController.SetPanel(PanelController.Panel.Shop);
        }
        private void BackToGame()
        {
            Time.timeScale = 1f;
            panelController.SetPanel(PanelController.Panel.None);
        }
        private void ExitFromGame()
        {
            Application.Quit();
        }
    }
}

