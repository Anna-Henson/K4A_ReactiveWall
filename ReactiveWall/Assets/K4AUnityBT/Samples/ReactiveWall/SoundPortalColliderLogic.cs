using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPortalColliderLogic : MonoBehaviour
{
    public AudioSource AudioSourceClip;

    void OnCollisionEnter(Collision collision)
    {
        // Optional Debugging: 
        // Debug.Log(collision.gameObject.ToString());
        // Debug.Log(collision.relativeVelocity.magnitude);

        // Optional Debug Visualization: 
        // foreach (ContactPoint contact in collision.contacts)
        // {
        //     Debug.DrawRay(contact.point, contact.normal, Color.red);
        // }

        if (AudioSourceClip.isPlaying == false)
        {
            AudioSourceClip.Play();
        }
    }
}
