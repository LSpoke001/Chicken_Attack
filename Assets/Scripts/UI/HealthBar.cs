using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack.UI
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Player player;
        [SerializeField] private GameObject heart;
        
        private List<GameObject> hearts = new List<GameObject>();

        private void Start()
        {
            player.Health.CheangeHealth += HealthBarChange;
        }

        private void OnDisable()
        {
            player.Health.CheangeHealth -= HealthBarChange;
        }

        private void HealthBarChange(int value)
        {
            if (hearts.Count < value)
            {
                CreateHearts(value);
            }
            else if (hearts.Count > value)
            {
                Destroy(hearts[hearts.Count - 1].gameObject);
                hearts.Remove(hearts[hearts.Count - 1]);
            }
        }

        private void CreateHearts(int value)
        {
            for (int i = 0; i < value; i++)
            {
                var newHeart = Instantiate(heart, transform);
                hearts.Add(newHeart);
            }
        }
    }
}


