using System;
using System.Collections;
using System.Collections.Generic;
using Steamworks;
using UnityEngine;

public class LeaveSteamLobby : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            leave_server();
        }
    }

    public void leave_server()
    {
        SteamMatchmaking.LeaveLobby(SteamLobby.Instance.CSteamId);
        Debug.Log("Leave");
    }
}