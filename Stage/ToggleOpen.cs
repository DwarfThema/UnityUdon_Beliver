
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.Udon.Common;

public class ToggleOpen : UdonSharpBehaviour
{
    Animator anim;
    [SerializeField] GameObject screen;
    [SerializeField, UdonSynced] bool networkBool = false;

    void Start()
    {
        anim = screen.GetComponent<Animator>();
    }

    public override void Interact()
    {
        Networking.SetOwner(Networking.LocalPlayer, gameObject);

        if(anim.GetBool("isOpen") == true)
        {
            anim.SetBool("isOpen", false);
            networkBool = false;
            RequestSerialization();
        }
        else
        {
            anim.SetBool("isOpen", true);
            networkBool = true;
            RequestSerialization();
        }
    }

    public override void OnDeserialization()
    {
        anim.SetBool("isOpen", networkBool);
    }
}
