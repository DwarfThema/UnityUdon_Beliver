
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ToggleSwitch : UdonSharpBehaviour
{
    [SerializeField] GameObject toggleObj;
    [UdonSynced] bool networkBool = true;

    void Start(){
        toggleObj.SetActive(true);
    }


    public override void Interact()
    {
        Networking.SetOwner(Networking.LocalPlayer, gameObject);
        Networking.SetOwner(Networking.LocalPlayer, toggleObj);
        networkBool = !networkBool;
        toggleObj.SetActive(networkBool);
        RequestSerialization();
    }

    public override void OnDeserialization()
    {
        toggleObj.SetActive(networkBool);
    }
}
