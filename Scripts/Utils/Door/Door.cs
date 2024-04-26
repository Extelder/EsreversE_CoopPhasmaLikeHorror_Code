using Mirror;
using UniRx;
using UnityEngine;


public class Door : NeworkBehaviour, IInteractable
{
    [SyncVar] public ReactiveProperty<bool> Opened = new ReactiveProperty<bool>();

    private bool _locked;

    public void Interact()
    {
        TryUnlock();
        if (Opened.Value)
            Close();
        if (!Opened.Value)
            Open();
    }


    private void TryUnlock()
    {
    }

    private void Unlock()
    {
    }

    private void Open()
    {
        if (!_locked)
            Opened.Value = true;
    }

    private void Close()
    {
        Opened.Value = false;
        _locked = false;
    }
}

public class NeworkBehaviour
{
}