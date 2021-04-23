using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
public class RoomListingsMenu : MonoBehaviourPunCallbacks
{
    [SerializeField]
    private Transform _conntent; 
    [SerializeField]
    private RoomListing _roomLisitng;

    private List<RoomListing> _Listings=new List<RoomListing>();

    public override void OnRoomListUpdate(List<RoomInfo> roomList)
    {
        foreach(RoomInfo info in roomList)
        {
            if(info.RemovedFromList)
            {
                int index= _Listings.FindIndex(x=>x.RoomInfo.Name==info.Name);
                if(index!=-1)
                {
                    Destroy(_Listings[index].gameObject);
                    _Listings.RemoveAt(index);
                }
            }
            else
            {
                RoomListing listing= Instantiate(_roomLisitng,_conntent);
                if(listing!=null)
                {
                    listing.SetRoomInfo(info); 
                    _Listings.Add(listing); 
                }
            }

        }
    }
}
