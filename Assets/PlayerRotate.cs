using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float hor;
    private float ver;
    public float speed = 5f;
    public Joystick joystick;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        hor += joystick.Horizontal * speed * Time.deltaTime;
        ver += joystick.Vertical * speed * Time.deltaTime;
        
        hor = Mathf.Clamp(hor, -145, 0);
        ver = Mathf.Clamp(ver, -12, 10);
        
        transform.rotation = Quaternion.Euler(-ver,hor, 0f);
    }
}
