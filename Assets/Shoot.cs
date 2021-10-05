using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 10f;
    public Transform bulletCreate;
    public Button button;
    
    private RaycastHit hit;

    private void OnEnable()
    {
        button.onClick.AddListener(ShootGun);
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(ShootGun);
    }
    
    private void ShootGun()
    {
        var newBullet = Instantiate(bullet, bulletCreate);
        newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);   
        
    }
}
