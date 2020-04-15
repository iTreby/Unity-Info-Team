using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerNetwork : MonoBehaviour
{

    public MonoBehaviour[] scriptsToIgnore;
    private PhotonView photonView;

    // Start is called before the first frame update
    void Start()
    {
        //Find other player and disable the code to not input their control
        photonView = GetComponent<PhotonView>();
        if (!photonView.IsMine)
        {
            foreach (var script in scriptsToIgnore)
            {
                script.enabled = false;
            }
        }
    }

}
