
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class EnterInteract : UdonSharpBehaviour
{
    [SerializeField] GameObject blackUI;

    public override void Interact()
    {
        blackUI.SetActive(true);
    }
}
