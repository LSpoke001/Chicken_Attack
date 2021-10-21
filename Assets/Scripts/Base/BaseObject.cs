using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChickenAttack
{
    public abstract class BaseObject : MonoBehaviour
    {
        protected GameObject _gameObject;
        protected Transform _transform;
        protected Rigidbody _rigidbody;
        protected Vector3 _position;
        protected Vector3 _rotation;

        public GameObject GetGameObject
        {
            get { return _gameObject; }
        }

        public Transform GetTransform
        {
            get { return _transform; }
        }

        public Rigidbody GetRigidbody
        {
            get { return _rigidbody; }
        }

        public Vector3 GetVector3
        {
            get { return _position; }
        }

        protected virtual void Awake()
        {
            _gameObject = gameObject;
            _transform = _gameObject.transform;
            _rigidbody = _gameObject.GetComponent<Rigidbody>();
            _position = _transform.position;
        }
    }
}

