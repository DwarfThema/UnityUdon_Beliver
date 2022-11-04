
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ToggleOpen : UdonSharpBehaviour
{   
    [SerializeField] Animator anim;

    public override void Interact()
    {
        if(anim.GetBool("isOpen") == true){
            anim.SetBool("isOpen", false);
        }else{
            anim.SetBool("isOpen", true);
        }

    }
}
