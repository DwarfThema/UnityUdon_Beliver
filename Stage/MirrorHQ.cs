
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MirrorHQ : UdonSharpBehaviour
{
    [SerializeField] GameObject mirrorHQ;
    [SerializeField] GameObject mirrorLQ;

    public override void Interact()
    {
        if(mirrorHQ.activeInHierarchy == true){
            mirrorHQ.SetActive(false);
        }else{
            mirrorHQ.SetActive(true);
        }
        mirrorLQ.SetActive(false);
    }
}
