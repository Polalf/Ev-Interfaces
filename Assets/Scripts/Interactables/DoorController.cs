using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour , Interaction
{
    [SerializeField] private int scene;
    public void Interact()
    {
        SceneManager.LoadScene(scene);
    }
}
