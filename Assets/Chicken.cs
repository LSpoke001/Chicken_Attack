using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    private Transform player;
    public float speed = 10f;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        player = FindObjectOfType<PlayerRotate>().transform;
    }

    void Update()
    {
        Vector3 distance = transform.position - player.position;
        Quaternion rotation = Quaternion.LookRotation(-distance);
        transform.rotation = rotation;
        transform.Translate(Vector3.forward * Time.deltaTime);
        animator.SetBool("Run", true);
    }
}
