using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class DisableGameobjectsWithOwner : MonoBehaviour
{
     [SerializeField] private GameObject[] _objects;
     [SerializeField] private NetworkIdentity _networkIdentity;

     private void Start()
     {
          if (_networkIdentity.isOwned)
          {
               for (int i = 0; i < _objects.Length; i++)
               {
                    _objects[i].SetActive(false);
               }
          }
     }
}
