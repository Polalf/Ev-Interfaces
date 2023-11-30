using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionsManager : MonoBehaviour
{
    private Interaction actualInteraction;
    

    // Update is called once per frame
    void Update()
    {
        if(actualInteraction != null)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                actualInteraction.Interact();
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Interaction interaction))
        {
            actualInteraction = interaction;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Interaction interaction))
        {
            if(interaction == actualInteraction) actualInteraction= null;
        }
    }
}
