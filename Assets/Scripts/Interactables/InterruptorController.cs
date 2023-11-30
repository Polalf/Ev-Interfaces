using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InterruptorController : MonoBehaviour, Interaction
{
    public UnityEvent active;
    
    public void Interact()
    {
        active?.Invoke();
    }
}
