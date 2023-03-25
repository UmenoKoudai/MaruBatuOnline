using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;
using ExitGames.Client.Photon;
using UnityEngine.SceneManagement;

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
    public void JoinRoom()
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
        JoinLobby();
    }

    //���r�[�ɓ�������
    public override void OnJoinedLobby()
    {
        Debug.Log("���r�[�ɓ�����");
    }

    //���r�[����o����
    public override void OnLeftLobby()
    {
        Debug.Log("���r�[�ɓ���Ȃ�����");
    }

    //���[�����쐬���ꂽ��
    public override void OnCreatedRoom()
    {
        Debug.Log("���[�����쐬����");
    }

    //���[���̍쐬�Ɏ��s������
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("���[�����쐬�ł��Ȃ�����" + message);
    }

    //���[���ɓ�������
    public override void OnJoinedRoom()
    {
        PhotonNetwork.IsMessageQueueRunning = false;
        SceneManager.LoadSceneAsync("Game", LoadSceneMode.Single);
        Debug.Log("���[���ɓ�����");
    }

    //���[���ɓ���̂����s�����Ƃ�
    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        Debug.Log("���[���ɓ���Ȃ�����" + message);
    }

    //�����_���ȃ��[���ɓ���̂����s�����Ƃ�
    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("�����_���ȃ��[���ɓ���Ȃ�����" + message);
    }

    //���[������o����
    public override void OnLeftRoom()
    {
        Debug.Log("���[������o��");
    }

    //���̃v���C���[�����[���ɓ����Ă����Ƃ�
    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.Log(newPlayer.NickName + "����������");
    }

    //���̃v���C���[���o�Ă������Ƃ�
    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.Log(otherPlayer.NickName + "���ޏo����");
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
