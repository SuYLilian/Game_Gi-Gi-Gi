using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_b : MonoBehaviour
{
    public GameObject item;
    public int num=3;
    private GameObject camvas_b;

    private void Start()
    {

        camvas_b = GameObject.FindGameObjectWithTag("canvas_b");

    }

    public void SpawnDropprdItem()
    {

        Instantiate(item, camvas_b.transform, false);

    }
}
