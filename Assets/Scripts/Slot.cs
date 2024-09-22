using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private Inventory inventory;
    private GameObject canvas;
    public GameObject backRoomPanel;
    public int i;
    public int Room=0;
    

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
    }

    public void Update()
    {

        
        if (transform.childCount <= 0)
        {

            inventory.isFull[i] = false;

        }
   

    }

    public void RoomPlus()
    {

        Room++;

    }

    public void RoomReduce()
    {

        Room--;

    }

    public void DropItemButton()
    {

      
        if (Room==1)
        {
            if (inventory.itemRoom[i] == 1)
            {
                foreach (Transform child in transform)
                {

                    child.GetComponent<Spawn_p>().SpawnDropprdItem();
                    GameObject.Destroy(child.gameObject);

                }
            }

            else
            {

                Debug.Log(inventory.itemRoom[i]);
                Instantiate(backRoomPanel, canvas.transform, false);

            }

        }

        else if (Room == 0)
        {
            if (inventory.itemRoom[i] == 0)
            {
                foreach (Transform child in transform)
                {

                    child.GetComponent<Spawn_y>().SpawnDropprdItem();
                    GameObject.Destroy(child.gameObject);

                }
            }

            else
            {

                Debug.Log(inventory.itemRoom[i]);
                Instantiate(backRoomPanel, canvas.transform, false);

            }
        }

        else if (Room == 2)
        {

            if (inventory.itemRoom[i] == 2)
            {
                foreach (Transform child in transform)
                {

                    child.GetComponent<Spawn_b>().SpawnDropprdItem();
                    GameObject.Destroy(child.gameObject);

                }
            }

            else
            {

                Debug.Log(inventory.itemRoom[i]);
                Instantiate(backRoomPanel, canvas.transform, false);

            }


        }

 

    }


 
}
