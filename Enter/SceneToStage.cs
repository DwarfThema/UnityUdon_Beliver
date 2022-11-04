
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class SceneToStage : UdonSharpBehaviour
{
    [SerializeField] Transform targetPosition;
    [SerializeField] GameObject spawnObj;
    VRCPlayerApi player;
    void Start()
    {
        player = Networking.LocalPlayer;
    }

    public void SceneChange()
    {
        player.TeleportTo(targetPosition.position, targetPosition.rotation);
        Networking.SetOwner(player, spawnObj);
        spawnObj.transform.position = targetPosition.position;
        spawnObj.transform.rotation = targetPosition.rotation;
    }

    public void AnimDone()
    {
        gameObject.SetActive(false);
    }
}
