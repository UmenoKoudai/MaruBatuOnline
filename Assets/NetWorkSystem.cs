using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using ExitGames.Client.Photon;

public class NetWorkSystem : MonoBehaviourPunCallbacks
{
    [SerializeField] InputField _roomName;
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

    //ロビーに入る
    private void JoinLobby()
    {
        if(PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinLobby();
        }
    }

    //ルームに入る
    private void JoinRoom()
    {
        if(PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinOrCreateRoom(_roomName.name, new RoomOptions(), TypedLobby.Default);
        }
    }

    //Photonに接続した時に呼ばれる
    public override void OnConnected()
    {
        base.OnConnected();
    }

    //Photonから切断された時呼ばれる
    public override void OnDisconnected(DisconnectCause cause)
    {
        base.OnDisconnected(cause);
    }

    //マスターサーバーに接続したときに呼び出す
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
    }

    //ロビーに入った時
    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
    }

    //ロビーから出た時
    public override void OnLeftLobby()
    {
        base.OnLeftLobby();
    }

    //ルームが作成された時
    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
    }

    //ルームの作成に失敗した時
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        base.OnCreateRoomFailed(returnCode, message);
    }

    //ルームに入った時
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
    }

    //ルームに入るのを失敗したとき
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
    }

    //ランダムなルームに入るのを失敗したとき
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        base.OnJoinRandomFailed(returnCode, message);
    }

    //ルームから出た時
    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
    }

    //他のプレイヤーがルームに入ってきたとき
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        base.OnPlayerEnteredRoom(newPlayer);
    }

    //他のプレイヤーが出ていったとき
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        base.OnPlayerLeftRoom(otherPlayer);
    }

    /////////////////////////////////////////
    //今回のゲームではこれから下は使わない//
   /////////////////////////////////////////

    //マスタークライアントが切り替わった時
    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        base.OnMasterClientSwitched(newMasterClient);
    }

    //ロビーの情報が変わった時
    public override void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
    {
        base.OnLobbyStatisticsUpdate(lobbyStatistics);
    }

    //ルームリストが更新された時
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        base.OnRoomListUpdate(roomList);
    }

    //ルームのプロフィールが更新された時
    public override void OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
    {
        base.OnRoomPropertiesUpdate(propertiesThatChanged);
    }

    //プレイヤーのプロパティーが更新された時
    public override void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
    {
        base.OnPlayerPropertiesUpdate(targetPlayer, changedProps);
    }

    //フレンドリストが更新された時
    public override void OnFriendListUpdate(List<FriendInfo> friendList)
    {
        base.OnFriendListUpdate(friendList);
    }

    //地域リストが更新された時
    public override void OnRegionListReceived(RegionHandler regionHandler)
    {
        base.OnRegionListReceived(regionHandler);
    }

    //WebRpcのレスポンスがあった時
    public override void OnWebRpcResponse(OperationResponse response)
    {
        base.OnWebRpcResponse(response);
    }

    //カスタム認証のレスポンスがあった時
    public override void OnCustomAuthenticationResponse(Dictionary<string, object> data)
    {
        base.OnCustomAuthenticationResponse(data);
    }

    //カスタム認証が失敗したとき
    public override void OnCustomAuthenticationFailed(string debugMessage)
    {
        base.OnCustomAuthenticationFailed(debugMessage);
    }
}
