using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class DisableGameobjectWithoutAutority : NetworkBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private void Start()
    {
        if (!isOwned)
        {
            _gameObject.SetActive(false);
        }
    }
}
