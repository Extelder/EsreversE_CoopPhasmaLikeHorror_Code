using System;
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class RoofChecker : MonoBehaviour
{
    [SerializeField] private Collider[] _ignoreCollider;

    public bool RoofDetect { get; private set; }

    private void OnTriggerEnter(Collider other)
    {
        foreach (var collider in _ignoreCollider)
        {
            if (other == collider)
                return;
        }

        RoofDetect = true;
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var collider in _ignoreCollider)
        {
            if (other == collider)
                return;
        }

        RoofDetect = false;
    }
}