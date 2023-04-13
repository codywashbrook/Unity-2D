using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractable : MonoBehaviour
{
    public GameObject currentInterObj = null;
    public interactionObject currentInterObjScript = null;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentInterObj == true)
        {
            CheckInteraction();
        }
    }

    void CheckInteraction()
    {
        Debug.Log("Collected");

        if (currentInterObjScript.interType == interactionObject.InteractableType.nothing)
        { currentInterObjScript.Nothing(); }

        else if (currentInterObjScript.interType == interactionObject.InteractableType.info)
        { currentInterObjScript.InfoMessage(); }

        else if (currentInterObjScript.interType == interactionObject.InteractableType.pickup)
        { currentInterObjScript.PickUp(); }

        else if (currentInterObjScript.interType == interactionObject.InteractableType.dialogue)
        { currentInterObjScript.Dialogue(); }
    }
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("InterObject") == true)
        {
            currentInterObj = other.gameObject;
            currentInterObjScript = currentInterObj.GetComponent<interactionObject>();
        }
    }

    // Update is called once per frame
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObject") == true)
        {
            currentInterObj = null;
            currentInterObjScript = null;
        }
    }
}
