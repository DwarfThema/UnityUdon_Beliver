
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ToggleSwitch : UdonSharpBehaviour
{
    [SerializeField] GameObject toggleObj;

    public override void Interact()
    {
        if(toggleObj.activeInHierarchy == true){
            toggleObj.SetActive(false);
        }else{
            toggleObj.SetActive(true);
        }
    }
}
