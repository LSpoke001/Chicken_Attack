using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ChickenAttack
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] private GameObject _conteiner;
        [SerializeField] private int _capacity;

        private List<GameObject> _pool = new List<GameObject>();

        protected void Initialize(GameObject prefab)
        {
            for (int i = 0; i < _capacity; i++)
            {
                GameObject newChiken = Instantiate(prefab, _conteiner.transform);
                newChiken.SetActive(false);
                _pool.Add(newChiken);
            }
        }

        protected bool TryGetObject(out GameObject result)
        {
            result = _pool.FirstOrDefault(p => p.activeSelf == false);
            return result != null;
        }
    }
}

