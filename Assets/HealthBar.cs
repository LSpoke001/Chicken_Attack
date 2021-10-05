using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject heart;
    private List<GameObject> hearts = new List<GameObject>();

    private void OnEnable()
    {
        playerHealth.HealthChanged += HealthBarChange;
    }

    private void OnDisable()
    {
        playerHealth.HealthChanged -= HealthBarChange;
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
