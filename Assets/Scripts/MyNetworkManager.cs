using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
    
    public override void OnClientConnect(NetworkConnection conn)
    {
        base.OnClientConnect(conn);

        Debug.Log("I connected to a server!");
    }

    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);
        MyNetworkPlayer player =  conn.identity.GetComponent<MyNetworkPlayer>();
        if(player == null) { return; }
        player.SetDisplsyName($"Player{numPlayers}");

       
    }


}
