using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ChickenAttack.UI
{
    public class PanelController : MonoBehaviour
    {
        [SerializeField] private GameObject menuPanel;
        [SerializeField] private GameObject shopPanel;
        [SerializeField] private GameObject overPanel;
        [SerializeField] private Button menuButton;

        private PlayerHealth playerHealth;
        

        public enum Panel
        {
            None,
            Menu,
            Shop,
            Over,
        }

        private void Start()
        {
           SetPanel(Panel.None);
           playerHealth = MainController.inctance.GetPlayer.Health;
           playerHealth.Died += PlayerDied;
        }

        public void SetPanel(Panel panel)
        {
            menuPanel.SetActive(panel == Panel.Menu);
            shopPanel.SetActive(panel == Panel.Shop);
            overPanel.SetActive(panel == Panel.Over);
        }

        private void OnEnable()
        {
            menuButton.onClick.AddListener(TurnMenuPanel);
        }

        private void OnDisable()
        {
            menuButton.onClick.RemoveListener(TurnMenuPanel);
            playerHealth.Died -= PlayerDied;
        }

        private void TurnMenuPanel()
        {
            Time.timeScale = 0f;
            SetPanel(Panel.Menu);
        }

        private void PlayerDied()
        {
            Time.timeScale = 0f;
            SetPanel(Panel.Over);
        }
    }
}

