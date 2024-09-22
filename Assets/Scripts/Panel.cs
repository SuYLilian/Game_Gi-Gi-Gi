using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{
    public GameObject panel;

    public void OpenPanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }



    public void CloseItemButton()
    {

        transform.GetChild(1).gameObject.SetActive(false);

    }

}
