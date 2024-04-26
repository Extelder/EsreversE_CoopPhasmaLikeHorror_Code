using System;
using Mirror;
using Room;
using UnityEngine;


public class Enemy : NetworkBehaviour
{
    [Command(requiresAuthority = false)]
    public void PlayerLoseQte()
    {
    }

    [Command(requiresAuthority = false)]
    public void PlayerLoseHeartBeat()
    {
    }

    [Command(requiresAuthority = false)]
    public void PlayerHeard()
    {
    }
}