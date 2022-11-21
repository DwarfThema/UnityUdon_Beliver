
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class WaterFall : UdonSharpBehaviour
{
    public ParticleSystem myParticleSystem;

    void Start()
    {
        
    }

    private void Update()
    {
        if (Vector3.Angle(Vector3.down, transform.forward) <= 90f)
        {
            myParticleSystem.Play();
        }
        else
        {
            myParticleSystem.Stop();
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name.Contains("WaterCup"))
        {
            if(other.gameObject.transform.GetChild(0).localScale.z <= 1){
                other.gameObject.transform.GetChild(0).localScale += new Vector3(0, 0, 0.003f);
            }
        }
    }
}
