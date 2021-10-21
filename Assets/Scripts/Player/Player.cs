using System;
using System.Collections;
using System.Collections.Generic;
using ChickenAttack;
using UnityEditor.SceneManagement;
using UnityEngine;

namespace ChickenAttack
{
    public class Player : MonoBehaviour
    {
        private PlayerHealth health;
        private PlayerController controller;

        public PlayerHealth Health
        {
            get => health;
        }

        public PlayerController Controller
        {
            get => controller;
        }
        
        private void Awake()
        {
            health = gameObject.AddComponent<PlayerHealth>();
            controller = gameObject.AddComponent<PlayerController>();
        }
    }
}

