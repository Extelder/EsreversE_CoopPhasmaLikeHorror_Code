using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioTrigger : MonoBehaviour
{
    [field: SerializeField] public float Radius { get; set; }
    [SerializeField] public float DefaultRadius { get; set; }

    private void Awake()
    {
        DefaultRadius = Radius;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }

    public void ExecuteSound()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, Radius);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.TryGetComponent<Enemy>(out Enemy enemy))
            {
                enemy.PlayerHeard();
            }
        }
    }
}