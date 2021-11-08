using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ChickenAttack
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] protected GameObject _conteiner;
        protected int _capacity;

        private List<GameObject> _pool = new List<GameObject>();

        protected void Initialize(GameObject prefab)
        {
            for (int i = 0; i < _capacity; i++)
            {
                GameObject newObject = Instantiate(prefab, _conteiner.transform);
                newObject.SetActive(false);
                _pool.Add(newObject);
            }
        }
        protected bool TryGetObject(out GameObject result)
        {
            result = _pool.FirstOrDefault(p => p.activeSelf == false);
            return result != null;
        }
    }
}

