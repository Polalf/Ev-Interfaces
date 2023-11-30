using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour , Interaction
{
    [SerializeField] private GameObject lucecita;

    public void Interact()
    {
        lucecita.SetActive(true);
    }
}
