using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour , Interaction
{
    public void Interact()
    {
        Destroy(gameObject);
    }
}
