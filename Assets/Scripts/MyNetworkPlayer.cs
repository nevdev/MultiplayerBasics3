using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNetworkPlayer : NetworkBehaviour
{
    [SyncVar]
    [SerializeField]
    private string displayName = "Missing Name";

    public void SetDisplsyName(string newDisplayName)
    {
        displayName = newDisplayName;
    }
}
