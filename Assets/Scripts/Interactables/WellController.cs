using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellController : MonoBehaviour, Interaction
{
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip clip;
    public void Interact()
    {
        source.PlayOneShot(clip);
    }
}
