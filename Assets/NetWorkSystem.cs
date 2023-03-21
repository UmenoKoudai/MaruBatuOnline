using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class NetWorkSystem : MonoBehaviourPunCallbacks
{
    private void Start()
    {
        Connect("1.0");
    }
    private void Connect(string gameVersion)
    {
        if(PhotonNetwork.IsConnected == false)
        {
            PhotonNetwork.GameVersion = gameVersion;
            PhotonNetwork.ConnectUsingSettings();
        }
    }
}
