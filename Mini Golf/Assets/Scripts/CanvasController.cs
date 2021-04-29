using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using Photon.Realtime;

public class CanvasController : MonoBehaviourPunCallbacks
{

    public TMP_InputField inputUserName;
    public TMP_Dropdown dropdownRoomName;
    public TMP_InputField inputRoomName;
    public TMP_Text textHeader;
    public TMP_Text textPlayers;

    void Start()
    {
        UpdateRoomList();
    }

    public void JoinRoom()
    {
        NetworkManager.instance.JoinRoom(inputUserName.text, dropdownRoomName.options[dropdownRoomName.value].text);
    }

    public void CreateRoom()
    {
        bool alreadyExists = false;
        foreach (RoomInfo roomInfo in NetworkManager.roomList)
        {
            if (roomInfo.Name == inputRoomName.text)
            {
                alreadyExists = true;
                break;
            }
        }
        if (!alreadyExists)
            NetworkManager.instance.CreateRoom(inputUserName.text, inputRoomName.text);
    }

    public override void OnCreatedRoom()
    {
        photonView.RPC("UpdatePlayerList", RpcTarget.All);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        photonView.RPC("UpdatePlayerList", RpcTarget.All);
    }

    [PunRPC]
    public void UpdatePlayerList()
    {
        textHeader.text = "Players in Room " + PhotonNetwork.CurrentRoom.Name + ":";
        string str = "";
        foreach (var player in PhotonNetwork.PlayerList)
            str += player.NickName + "\n";
        textPlayers.text = str;
    }

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        UpdateRoomList();
    }

    public void UpdateRoomList()
    {
        dropdownRoomName.ClearOptions();
        List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();
        foreach (RoomInfo roomInfo in NetworkManager.roomList)
            options.Add(new TMP_Dropdown.OptionData(roomInfo.Name));
        dropdownRoomName.AddOptions(options);
    }

}
