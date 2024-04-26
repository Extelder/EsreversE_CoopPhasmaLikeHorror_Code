using System;
using Mirror;
using UniRx;
using UnityEngine;

public class DoorAnimator : DefaultAnimator
{
    [SerializeField] private NetworkIdentity _identity;
    [SerializeField] private Door _door;

    private CompositeDisposable _disposable = new CompositeDisposable();

    private void Start()
    {
        _door.Opened.Subscribe(_ =>
        {
            if (_)
                Open();
            else
                Close();
        }).AddTo(_disposable);
    }

    private void OnDisable()
    {
        _disposable.Clear();
    }

    public void Open()
    {
        SetAnimationBool("IsOpen", true);
    }

    public void Close()
    {
        SetAnimationBool("IsOpen", false);
    }

    public override void DisableAllAnimations()
    {
        Animator.SetBool("IsOpen", false);
    }
}