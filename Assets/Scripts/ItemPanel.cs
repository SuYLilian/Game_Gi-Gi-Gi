using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPanel : MonoBehaviour
{
    public GameObject itemPanel,SecondPanel;
    private GameObject canvas;

    public void OpenItemPanel_Y()
    {
        canvas = GameObject.FindGameObjectWithTag("canvas_y");
        Instantiate(itemPanel, canvas.transform, false);

    }

    public void OpenItemPanel_P()
    {
        canvas = GameObject.FindGameObjectWithTag("canvas_p");
        Instantiate(itemPanel, canvas.transform, false);

    }

    public void OpenItemPanel_B()
    {
        canvas = GameObject.FindGameObjectWithTag("canvas_b");
        Instantiate(itemPanel, canvas.transform, false);

    }

    public void OpenItemPanel()
    {

        if (SecondLevel.isSecondLevel == false)
        {
            canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
            Instantiate(itemPanel, canvas.transform, false);
        }
        else if(SecondLevel.isSecondLevel == true)
        {
            canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
            Instantiate(SecondPanel, canvas.transform, false);
        }

    }

    public void CloseItemPanel()
    {

        Destroy(itemPanel);

    }

    public void CloseSecondPanel()
    {

        Destroy(SecondPanel);

    }

}
