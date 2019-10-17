using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Valve.VR.Extras;
using Valve.VR.InteractionSystem;
using UnityEngine.SceneManagement;
using Photon;

[PunRPC]
public class UIButton : MonoBehaviourPunCallbacks
{
    public SteamVR_LaserPointer laserPointer;

    private void Awake()
    {
        if (photonView.IsMine)
        {

            laserPointer.PointerIn += OnPointerIn;
            laserPointer.PointerOut += OnPointerOut;
            laserPointer.PointerClick += PointerClick;
        }

    }


    public void OnPointerIn(object sender, PointerEventArgs e)
    {

    }

    public void OnPointerOut(object sender, PointerEventArgs e)
    {


    }

    public void PointerClick(object sender, PointerEventArgs e)
    {
        if (e.target.name == "LeaveButton")
        {
            Debug.Log("Button was clicked");
            LeaveRoom();
        }
    }

    public void LeaveRoom()
    {
        Debug.Log("Return to lobby");
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameMenu");
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}


