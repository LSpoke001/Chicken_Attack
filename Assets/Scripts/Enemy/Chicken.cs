using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    public class Chicken : BaseObject
    {
        private Transform player;
        //[SerializeField] private float speed = .0001f;
        [SerializeField] private int damage = 1;
        private Animator animator;

        private void Start()
        {
            animator = GetComponent<Animator>();
            player = FindObjectOfType<Player>().transform;
        }

        void Update()
        {
            Chasing();
        }

        private void Chasing()
        {
            Vector3 distance = transform.position - player.position;
            Quaternion rotation = Quaternion.LookRotation(-distance);
            GetTransform.rotation = rotation;
            GetTransform.Translate(Vector3.forward *Time.deltaTime);
            animator.SetBool("Run", true);
        }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.TryGetComponent(out PlayerHealth playerHealth))
            {
                playerHealth.HealthChange(damage);
                this.gameObject.SetActive(false);
            }
        }
    }
}

