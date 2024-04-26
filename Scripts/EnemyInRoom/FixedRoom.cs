using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace Room
{
    public class FixedRoom : MonoBehaviour
    {
        [field: SerializeField]
        public ReactiveProperty<bool> EnemyIn { get; private set; } = new ReactiveProperty<bool>();

        public Enemy Enemy { get; private set; }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<Enemy>(out Enemy enemy))
            {
                EnemyIn.Value = true;
                Enemy = enemy;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent<Enemy>(out Enemy enemy))
            {
                EnemyIn.Value = false;
                Enemy = null;
            }
        }
    }
}