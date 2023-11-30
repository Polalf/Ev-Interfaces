using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour, Interaction
{
    [SerializeField] private string dialog;
    public void Interact()
    {
        Debug.Log(dialog);
    }
}
