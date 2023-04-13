using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcquiredItems : MonoBehaviour
{
    [Header("Scripts")]
    public Inventory inventory;
    public interactionObject interactionObject;

    [Header("QuestItemNumber")]
    public int QuestItemNumber;

    private bool runOnce = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inventory.inventory[QuestItemNumber] == true && runOnce == true)
        {
            interactionObject.ToggleObjectsActive();
            runOnce = false;
        }
    }
}
