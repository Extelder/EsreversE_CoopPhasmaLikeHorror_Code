using System;
using Cinemachine;
using UniRx;
using UnityEngine;

public class CinemachineAnimator : DefaultAnimator
{
    [SerializeField] private CinemachineVirtualCamera _cinemachineVirtualCamera;
    [SerializeField] private Vector3 _crawlOffset;
    [SerializeField] private float _animationSmooth;
    
    private CinemachineTransposer _transposer;
    private CompositeDisposable _disposable = new CompositeDisposable();
    private Vector3 _defaultOffset;
    private Vector3 _currentOffset;
    private Vector3 _targetOffset;
    
    private void Awake()
    {
        _transposer = _cinemachineVirtualCamera.GetCinemachineComponent<CinemachineTransposer>();
        _defaultOffset = _transposer.m_FollowOffset;
        _targetOffset = _defaultOffset;

        Observable.EveryUpdate().Subscribe(_ =>
        {
            _currentOffset = Vector3.Lerp(_currentOffset, _targetOffset, _animationSmooth * Time.deltaTime);
            _transposer.m_FollowOffset = _currentOffset;
        }).AddTo(_disposable);
    }

    private void OnDisable()
    {
        _disposable.Clear();
    }

    public void CrawlDown()
    {
        _targetOffset = _crawlOffset;
    }

    public void StandUp()
    {
        _targetOffset = _defaultOffset;
    }
}