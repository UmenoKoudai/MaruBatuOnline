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

    //���r�[�ɓ���
    private void JoinLobby()
    {
        if(PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinLobby();
        }
    }

    //���[���ɓ���
    private void JoinRoom()
    {
        if(PhotonNetwork.IsConnected)
        {
            PhotonNetwork.JoinOrCreateRoom(_roomName.name, new RoomOptions(), TypedLobby.Default);
        }
    }

    //Photon�ɐڑ��������ɌĂ΂��
    public override void OnConnected()
    {
        base.OnConnected();
    }

    //Photon����ؒf���ꂽ���Ă΂��
    public override void OnDisconnected(DisconnectCause cause)
    {
        base.OnDisconnected(cause);
    }

    //�}�X�^�[�T�[�o�[�ɐڑ������Ƃ��ɌĂяo��
    public override void OnConnectedToMaster()
    {
        base.OnConnectedToMaster();
    }

    //���r�[�ɓ�������
    public override void OnJoinedLobby()
    {
        base.OnJoinedLobby();
    }

    //���r�[����o����
    public override void OnLeftLobby()
    {
        base.OnLeftLobby();
    }

    //���[�����쐬���ꂽ��
    public override void OnCreatedRoom()
    {
        base.OnCreatedRoom();
    }

    //���[���̍쐬�Ɏ��s������
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        base.OnCreateRoomFailed(returnCode, message);
    }

    //���[���ɓ�������
    public override void OnJoinedRoom()
    {
        base.OnJoinedRoom();
    }

    //���[���ɓ���̂����s�����Ƃ�
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        base.OnJoinRoomFailed(returnCode, message);
    }

    //�����_���ȃ��[���ɓ���̂����s�����Ƃ�
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        base.OnJoinRandomFailed(returnCode, message);
    }

    //���[������o����
    public override void OnLeftRoom()
    {
        base.OnLeftRoom();
    }

    //���̃v���C���[�����[���ɓ����Ă����Ƃ�
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        base.OnPlayerEnteredRoom(newPlayer);
    }

    //���̃v���C���[���o�Ă������Ƃ�
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        base.OnPlayerLeftRoom(otherPlayer);
    }

    /////////////////////////////////////////
    //����̃Q�[���ł͂��ꂩ�牺�͎g��Ȃ�//
   /////////////////////////////////////////

    //�}�X�^�[�N���C�A���g���؂�ւ������
    public override void OnMasterClientSwitched(Player newMasterClient)
    {
        base.OnMasterClientSwitched(newMasterClient);
    }

    //���r�[�̏�񂪕ς������
    public override void OnLobbyStatisticsUpdate(List<TypedLobbyInfo> lobbyStatistics)
    {
        base.OnLobbyStatisticsUpdate(lobbyStatistics);
    }

    //���[�����X�g���X�V���ꂽ��
    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        base.OnRoomListUpdate(roomList);
    }

    //���[���̃v���t�B�[�����X�V���ꂽ��
    public override void OnRoomPropertiesUpdate(ExitGames.Client.Photon.Hashtable propertiesThatChanged)
    {
        base.OnRoomPropertiesUpdate(propertiesThatChanged);
    }

    //�v���C���[�̃v���p�e�B�[���X�V���ꂽ��
    public override void OnPlayerPropertiesUpdate(Player targetPlayer, ExitGames.Client.Photon.Hashtable changedProps)
    {
        base.OnPlayerPropertiesUpdate(targetPlayer, changedProps);
    }

    //�t�����h���X�g���X�V���ꂽ��
    public override void OnFriendListUpdate(List<FriendInfo> friendList)
    {
        base.OnFriendListUpdate(friendList);
    }

    //�n�惊�X�g���X�V���ꂽ��
    public override void OnRegionListReceived(RegionHandler regionHandler)
    {
        base.OnRegionListReceived(regionHandler);
    }

    //WebRpc�̃��X�|���X����������
    public override void OnWebRpcResponse(OperationResponse response)
    {
        base.OnWebRpcResponse(response);
    }

    //�J�X�^���F�؂̃��X�|���X����������
    public override void OnCustomAuthenticationResponse(Dictionary<string, object> data)
    {
        base.OnCustomAuthenticationResponse(data);
    }

    //�J�X�^���F�؂����s�����Ƃ�
    public override void OnCustomAuthenticationFailed(string debugMessage)
    {
        base.OnCustomAuthenticationFailed(debugMessage);
    }
}
