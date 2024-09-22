using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_y : MonoBehaviour
{

    public GameObject item;
    public int num = 1;
    private GameObject camvas;

    private void Start()
    {

        camvas = GameObject.FindGameObjectWithTag("canvas_y");

    }

    public void SpawnDropprdItem()
    {

        Instantiate(item, camvas.transform, false);

    }

}
