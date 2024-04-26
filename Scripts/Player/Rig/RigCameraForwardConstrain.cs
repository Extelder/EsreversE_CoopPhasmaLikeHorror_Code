using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UniRx;
using UnityEngine;

public class RigCameraForwardConstrain : MonoBehaviour
{
    [SerializeField] private NetworkIdentity _networkIdentity;
    [SerializeField] private Transform _camera;
    [SerializeField] private float _distance;
    private CompositeDisposable _disposable = new CompositeDisposable();

    private void Start()
    {
        if (!_networkIdentity.isOwned)
            Destroy(this);
    }

    private void OnEnable()
    {
        Observable.EveryUpdate()
            .Subscribe(_ => { transform.position = _camera.position + _camera.forward * _distance; })
            .AddTo(_disposable);
    }

    private void OnDisable()
    {
        _disposable.Clear();
    }
}