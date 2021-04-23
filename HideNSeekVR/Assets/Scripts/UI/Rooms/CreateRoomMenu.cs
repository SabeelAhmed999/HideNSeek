﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class CreateRoomMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private TextMeshProUGUI _roomName;
    public void OnClicl_CreateRoom()
    {
        if(!PhotonNetwork.IsConnected)
            return;
        RoomOptions options = new RoomOptions();
        options.MaxPlayers=10;
        PhotonNetwork.JoinOrCreateRoom(_roomName.text,options,TypedLobby.Default);
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("CreatedRoom successfully.",this );
    }

    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Room creation failed."+message,this );
    }
}
