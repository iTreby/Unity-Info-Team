﻿using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;

public class NetworkController : MonoBehaviourPunCallbacks
{

    private static NetworkController _instance = null;

    public static NetworkController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<NetworkController>();
            }
            return _instance;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("connected" + PhotonNetwork.CloudRegion);
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        PhotonNetwork.JoinOrCreateRoom("Roon", new RoomOptions { MaxPlayers = 2 }, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        //
        PhotonNetwork.Instantiate("Hero", new Vector3(Random.Range(1f,1.5f),0.32f,Random.Range(35f,55f)), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
