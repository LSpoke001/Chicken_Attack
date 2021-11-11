using System;
using System.Collections;
using System.Collections.Generic;
using ChickenAttack;
using UnityEngine;
using UnityEngine.UI;
using ChickenAttack.Controller;

namespace ChickenAttack
{
    public class MainController : MonoBehaviour
    {
        [SerializeField]private Player player;
        [SerializeField]private Joystick joystick;
        [SerializeField]private Button attackButton;
        
        private WeaponsManager weaponsManager;

        public Player GetPlayer
        {
            get { return player; }
        }

        public WeaponsManager WeaponsManager
        {
            get => weaponsManager;
        }

        public Joystick GetJoistic
        {
            get { return joystick; }
        }

        public Button AttackButton
        {
            get { return attackButton; }
        }

        private void Awake()
        {
            weaponsManager = GetComponent<WeaponsManager>();
        }
    }
}

