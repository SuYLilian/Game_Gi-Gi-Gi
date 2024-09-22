using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutInBackpack : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButten;
    public GameObject item;

  
    

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
    }

    public void putInBackpack()
    {
        for(int i=0;i<inventory.slots.Length;i++)
        {
            if (inventory.isFull[i]==false)
            {
                Destroy(item);
                inventory.isFull[i] = true;
                inventory.itemRoom[i] = Camera.room;
                Instantiate(itemButten, inventory.slots[i].transform, false);
                itemButten.SetActive(true);
               

             
                break;

            }
        }
    }
   
}
