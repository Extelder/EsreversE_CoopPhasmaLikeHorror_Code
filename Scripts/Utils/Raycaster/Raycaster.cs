using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycaster : MonoBehaviour 
{
    [field: SerializeField] public Transform Camera { get; private set; }
    [field: SerializeField] public float Range { get; private set; }

    public bool CheckColliderHasComponent<T>(out Collider collider)
    {
        bool detected = GetHitCollider(out collider) && collider.TryGetComponent<T>(out T t);
        return detected;
    }

    public bool GetHitCollider(out Collider collider)
    {
        collider = GetRaycastHit().collider;
        return collider; 
    }

    public RaycastHit GetRaycastHit()
    {
        RaycastHit hit = new RaycastHit();
        ThrowRaycast(ref hit);
        return hit;
    }

    public void ThrowRaycast(ref RaycastHit outHit)
    {
        Physics.Raycast(Camera.transform.position, Camera.forward, out outHit, Range);
    }
}
