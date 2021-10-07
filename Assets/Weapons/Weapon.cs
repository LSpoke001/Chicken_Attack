using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenuAttribute(menuName = "Weapon", fileName = "New Weapon", order = 51)]
public class Weapon : ScriptableObject
{
    public string name;
    public Sprite icon;
    public int price;
    public GameObject gun;
    public bool isBuy = false;

    public void Buy()
    {
        isBuy = true;
    }
}
