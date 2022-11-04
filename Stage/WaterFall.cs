
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
        if (other.gameObject.name == "water")
        {
            if(other.gameObject.transform.localScale.z <= 100){
                other.gameObject.transform.localScale += new Vector3(0, 0, 0.5f);
            }
        }
    }
}
