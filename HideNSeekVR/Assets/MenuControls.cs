using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
public class MenuControls :MonoBehaviourPunCallbacks
{/* 
 [SerializeField] private string versionName="0.1";
[SerializeField] private GameObject UsernameMenu;
[SerializeField] private GameObject ConnectPanel;
[SerializeField] private TMP_InputField UserInput;
[SerializeField] private TMP_InputField CreatGameInput;
[SerializeField] private TMP_InputField JoinGameInput;
[SerializeField] private GameObject StartButton;

     private void Awake()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby(TypedLobby.Default);
        Debug.Log("Connected");
    }
    // Start is called before the first frame update
    void Start()
    {
        UsernameMenu.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeUserNameInput()
    {
        if(UserInput.text.Length>=3)
        {
            StartButton.SetActive(true);
        }
        else
        {
            StartButton.SetActive(false);
        }
    }
    public void SetUserName()
    {
        UsernameMenu.SetActive(false);
        PhotonNetwork.NickName=UserInput.text;
    }

    public void CreatGame()
    {
        PhotonNetwork.CreateRoom(CreatGameInput.text, new RoomOptions(){MaxPlayers=10},null);
    }
    public void JoinGame()
    {
        RoomOptions roomOptions= new RoomOptions();
        roomOptions.MaxPlayers=10;
        PhotonNetwork.JoinOrCreateRoom(JoinGameInput.text, roomOptions,TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("GamePlay"); 
    } */
}
  