using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace ChickenAttack.Controller
{
    public class InputController : MonoBehaviour
    {
        [Inject] private MainController controller;
        private Joystick joystick;
        private Button attackButton;
        
        private float hor;
        private float ver;
        private float xCurrent;
        private float yCurrent;
        private float speed = 300f;
        private float xCcurrentVelocity;
        private float yCcurrentVelocity;
        private float smoothTime = 0.1f;
    
       
    
        private void Start()
        {
            joystick = controller.GetJoistic;
            attackButton = controller.AttackButton;
            attackButton.onClick.AddListener(ShootWeapon);
        }
        private void OnDisable()
        {
            attackButton.onClick.RemoveListener(ShootWeapon);
        }
        private void Update()
        {
            InputPlayerControll();
        }
    
        private void InputPlayerControll()
        {
            hor += joystick.Horizontal * speed * Time.deltaTime;
            if (joystick.Vertical > .4f || joystick.Vertical < -.4f)
            {
                ver += joystick.Vertical * speed * Time.deltaTime;
            }
            
            xCurrent = Mathf.SmoothDamp(xCurrent, hor, ref xCcurrentVelocity, smoothTime);
            yCurrent = Mathf.SmoothDamp(yCurrent, ver, ref yCcurrentVelocity, smoothTime);
            
            hor = Mathf.Clamp(xCurrent, 50, 165);
            ver = Mathf.Clamp(yCurrent, -12, 20);
            controller.GetPlayer.Controller.PlayerRotate(ver, hor);
            //MainController.inctance.GetPlayer.Controller.PlayerRotate(ver, hor);
        }
    
        private void ShootWeapon()
        {
            controller.WeaponsManager.ShootController.Shoot();
           // MainController.inctance.WeaponsManager.ShootController.Shoot();
        }
    }
}

