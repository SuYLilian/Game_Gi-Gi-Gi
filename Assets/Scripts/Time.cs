using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    /*public Text CountdowmText;
    public GameObject Countdown,FailPanel;
    [SerializeField] float currentTime,duration;
    GameObject canvas;

     public void TimeCountDown()
    {

        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        Countdown.SetActive(true);
        currentTime = duration;
        CountdowmText.text = currentTime.ToString();
        StartCoroutine(TimeIEn());

    }

    IEnumerator TimeIEn()
    {

        while(currentTime>=0&&SecondLevel.isGameOver==false)
        {
           
                CountdowmText.text = currentTime.ToString();
                yield return new WaitForSeconds(1f);
                currentTime--;
                Debug.Log(currentTime);
            
        }
        CountdowmText.text = "";
        Countdown.SetActive(false);
        if (SecondLevel.isGameOver == false)
        {
            Instantiate(FailPanel, canvas.transform, false);
            SecondLevel.isGameOver = true;
        }

    }*/

}

