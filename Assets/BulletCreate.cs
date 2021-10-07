using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreate : MonoBehaviour
{
    public Transform bulletPoint;
    public float speed = 10000f;

    /*rivate Camera camera;
    private RaycastHit enemyHit;
    private float distance = 100f;*/
    

    public void Shoot(GameObject bulletPref)
    {
        var newBullet = Instantiate(bulletPref, bulletPoint);
        newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * speed);
    }
}
//Тут примерный код для прицела
/*
        var rayOrigin = camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
        var newBullet = Instantiate(bulletPref, bulletPoint);
        if (Physics.Raycast(rayOrigin, camera.transform.forward, out enemyHit, distance))
        {
            if (enemyHit.collider.gameObject.GetComponent<Chicken>())
            {
                Vector3 distance = (enemyHit.transform.position - rayOrigin).normalized;
                newBullet.GetComponent<Rigidbody>().AddForce(distance * speed);
            }
            else
            {
                newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * speed);
            }
        }*/
