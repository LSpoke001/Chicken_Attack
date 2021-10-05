using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float hor;
    private float ver;
    private float xCurrent;
    private float yCurrent;
    private float xCcurrentVelocity;
    private float yCcurrentVelocity;
    public float smoothTime = 0.1f;
    public float speed = 5f;
    public Joystick joystick;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        hor += joystick.Horizontal * speed * Time.deltaTime;
        if (joystick.Vertical > .3f || joystick.Vertical < -.3f)
        {
            ver += joystick.Vertical * speed * Time.deltaTime;
        }
        
        xCurrent = Mathf.SmoothDamp(xCurrent, hor, ref xCcurrentVelocity, smoothTime);
        yCurrent = Mathf.SmoothDamp(yCurrent, ver, ref yCcurrentVelocity, smoothTime);
        
        hor = Mathf.Clamp(xCurrent, -145, 30);
        ver = Mathf.Clamp(yCurrent, -12, 0);
        
        transform.rotation = Quaternion.Euler(-ver,hor, 0f);
    }
}
