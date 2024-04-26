using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HostButton : MonoBehaviour
{
    private void OnEnable()
    {
        GetComponent<Button>().onClick.AddListener(HostLobby);
    }

    private void OnDisable()
    {
        GetComponent<Button>().onClick.RemoveListener(HostLobby);
    }

    private void HostLobby()
    {
        SteamLobby.Instance.HostLobby();
    }
}
