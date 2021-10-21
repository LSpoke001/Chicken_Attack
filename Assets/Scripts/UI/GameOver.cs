using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ChickenAttack.UI
{
    public class GameOver : MonoBehaviour
    {
        [SerializeField] private Button restart;
        [SerializeField] private Button exit;

        private void OnEnable()
        {
            restart.onClick.AddListener(Restart);
            exit.onClick.AddListener(Exit);
        }

        private void OnDisable()
        {
            restart.onClick.RemoveListener(Restart);
            exit.onClick.RemoveListener(Exit);
        }

        private void Restart()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Game");
        }

        private void Exit()
        {
            Application.Quit();
        }
    }
}

