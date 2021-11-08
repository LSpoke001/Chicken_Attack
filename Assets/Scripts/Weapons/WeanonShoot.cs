using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    public abstract class WeanonShoot : MonoBehaviour, IShootController
    {
        [SerializeField] private Transform bulletCreate;
        private AudioSource audio;
        protected GameObject bullet;
        protected float speed = 2000f;
        

        private void Start()
        {
            audio = GetComponent<AudioSource>();
        }

        public virtual void Instance(GameObject newBullet)
        {
            bullet = newBullet;

        }
        public virtual void Shoot()
        {
            var newBullet = Instantiate(bullet, bulletCreate.position, Quaternion.identity);
            audio.Play();
            newBullet.GetComponent<Rigidbody>().AddForce(bulletCreate.forward * speed);
        }
    }
}

