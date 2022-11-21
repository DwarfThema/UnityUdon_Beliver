
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3.Components;

public class Drink : UdonSharpBehaviour
{
    VRCPickup pickUp;
    VRCPlayerApi player;

    void Start()
    {
        player = Networking.LocalPlayer;
        pickUp = (VRCPickup)GetComponent((typeof(VRCPickup)));
    }

    public override void OnPickup()
    {
        Networking.SetOwner(player, gameObject);
    }

    public override void OnPickupUseDown()
    {
            if(gameObject.transform.GetChild(0).localScale.z >= 0){
                if(gameObject.transform.GetChild(0).localScale.z > 0.5f){
                    gameObject.transform.GetChild(0).localScale = new Vector3(1, 1, 0.5f);
                }else{
                    gameObject.transform.GetChild(0).localScale = new Vector3(1, 1, 0.1f);
                }
            }
    }
}
