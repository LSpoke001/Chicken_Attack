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
        public static MainController inctance;
    
        [SerializeField]private Player player;
        [SerializeField]private Joystick joystick;
        [SerializeField]private Button attackButton;

        private GameObject controller;
        private InputController inputController;
        private WeaponsManager weaponsManager;
    

        public InputController GetInputController
        {
            get { return inputController; }
        }

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
            inctance = this;
            controller = new GameObject("Controller");
            inputController = controller.AddComponent<InputController>();
            weaponsManager = GetComponent<WeaponsManager>();
        }
    }
}

