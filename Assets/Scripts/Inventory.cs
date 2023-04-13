using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [Header("InventoryObjects")]
    public GameObject[] item;
    public bool[] inventory;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            inventory[i] = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (!item[i].activeSelf)
            {
                inventory[i] = true;
            }

            else if (item[i].activeSelf)
            {
                inventory[i] = false;
            }
        }
    }
}
