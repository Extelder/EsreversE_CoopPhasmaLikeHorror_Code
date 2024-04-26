using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParentOnStart : MonoBehaviour
{
    [SerializeField] private Transform _parent;
    [SerializeField] private Transform _child;
    
    private void Start()
    {
        Invoke(nameof(SetParent), 1f);
    }

    private void SetParent()
    {
        _child.parent = _parent;
    }
}
