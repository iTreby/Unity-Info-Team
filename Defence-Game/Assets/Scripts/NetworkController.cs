using Photon.Pun;
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


    void Start()
    {
        //Connect to the server
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        //Once connected
        Debug.Log("connected" + PhotonNetwork.CloudRegion);
        PhotonNetwork.JoinLobby();
    }

    public override void OnJoinedLobby()
    {
        //Room of 2 players
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 2 }, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        //Create the main character 
        PhotonNetwork.Instantiate("Hero", new Vector3(1.2f,-3.3f,74f), Quaternion.identity);
    }
}
