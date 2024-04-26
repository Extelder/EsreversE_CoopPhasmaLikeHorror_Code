using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;
using UnityEngine.Serialization;

public class GameObjectChangingByAutority : NetworkBehaviour
{
    [FormerlySerializedAs("_fpsHands")] [SerializeField] private GameObject _firstGameObject;
    [FormerlySerializedAs("_character")] [SerializeField] private GameObject _secondGameObject;
    
    private void Start()
    {
        if (hasAuthority)
        {
            _firstGameObject.SetActive(true);
            _secondGameObject.SetActive(false);
        }
        else
        {
            _firstGameObject.SetActive(false);
            _secondGameObject.SetActive(true);
        }
    }
}
