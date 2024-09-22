using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePanel : MonoBehaviour
{
    public GameObject panel;

    public void closePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }

    public void closeSecondPanel()
    {

        Destroy(panel);

    }

}
