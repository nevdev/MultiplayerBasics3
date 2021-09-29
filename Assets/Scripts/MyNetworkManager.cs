﻿using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
    
    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);
        MyNetworkPlayer player =  conn.identity.GetComponent<MyNetworkPlayer>();
        //if(player == null) { return; }
        player.SetDisplayName($"Player{numPlayers}");

        Color displayColor = new Color(
                Random.Range(0f, 1f),
                Random.Range(0f, 1f),
                Random.Range(0f, 1f)
                );

        player.SetDisplayColour(displayColor);
    }


}
