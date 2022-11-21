
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3.Components;
using VRC.Udon.Common.Interfaces;

public class Respawn : UdonSharpBehaviour
{
    [SerializeField] GameObject[] obj;
    VRCObjectSync objectSync;

    void Start(){

    }

    public override void Interact()
    {
            Networking.SetOwner(Networking.LocalPlayer, gameObject);

            for(int i = 0; i < obj.Length; i++){
                Networking.SetOwner(Networking.LocalPlayer, obj[i]);
                objectSync = (VRCObjectSync)obj[i].GetComponent(typeof(VRCObjectSync));
                objectSync.Respawn();
            }
           
    }
}
