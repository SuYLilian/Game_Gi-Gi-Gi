using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_p : MonoBehaviour
{
    public GameObject item;
    public int num = 2;
    private GameObject camvas_p;

    private void Start()
    {

        camvas_p = GameObject.FindGameObjectWithTag("canvas_p");

    }

    public void SpawnDropprdItem()
    {

        Instantiate(item, camvas_p.transform, false);

    }
}
