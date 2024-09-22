using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondLevel : MonoBehaviour
{
    
    public static bool isSecondLevel=false;
    private static int[] random=new int[7];
    public static int num;
    public static int oldNum;
    public static int AnswerWrong, AnswerCorrect;
    public GameObject[] Event = new GameObject[7];
    public GameObject[] FailPanel = new GameObject[9];
    public GameObject WinPanel,gameOver_win,gameOver_fail;
    private GameObject canvas;
    public static bool isGameOver = false;
    public GameObject[] GameOverPanel=new GameObject[10];
    




    public void SelectEvent()
    {
        canvas = GameObject.FindGameObjectWithTag("Event");
        Transform eve = canvas.transform;
        foreach (Transform child in eve)
        {

            GameObject.Destroy(child.gameObject);

        }
        random[num] = UnityEngine.Random.Range(0, 7);
        for (int j = 0; j < num; j++)
        {
            while (random[j]==random[num])
            {
                j = 0;
                random[num] = UnityEngine.Random.Range(0, 7);
            }
        }
        oldNum = random[num];
        Instantiate(Event[random[num]], canvas.transform, false);
        num++;
        Destroy(gameObject);
        Debug.Log(oldNum);

        /*for (int i = 0; i < 5; i++)
        {
            rnd[i] = UnityEngine.Random.Range(0, 7);
            EventOrder[i] = Event[rnd[i]];
            for(int j=0;j<i;j++)
            {
                while(rnd[j]==rnd[i])
                {
                    j = 0;
                    rnd[i] = UnityEngine.Random.Range(0, 7);
                }
            }
        }
        EventOrder[0].SetActive(true);*/


    }

    public void UseFail()
    {
        AnswerWrong++;
        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum != 7&&AnswerWrong!=3)
        {

            Instantiate(FailPanel[oldNum], canvas.transform, false);
            Destroy(gameObject);
            Debug.Log("false");
        
        }
        else if(oldNum != 7 && AnswerWrong == 3)
        {
            Instantiate(GameOverPanel[oldNum], canvas.transform, false);
        }
       
    }

    public void UseFail_Apple()
    {
        AnswerWrong++;
        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum != 7&&oldNum!=3&&AnswerWrong!=3)
        {

            Instantiate(FailPanel[oldNum], canvas.transform, false);
            Destroy(gameObject);
            Debug.Log("false");

        }
        else if (oldNum != 7&&oldNum != 3 && AnswerWrong == 3)
        {
            Instantiate(GameOverPanel[oldNum], canvas.transform, false);
        }
        else if(oldNum != 7 && oldNum == 3&&AnswerWrong == 3)
        {
            Instantiate(GameOverPanel[7], canvas.transform, false);
        }
        else if (oldNum != 7 && oldNum == 3 && AnswerWrong != 3)
        {
            Instantiate(FailPanel[7], canvas.transform, false);
            Destroy(gameObject);
            Destroy(gameObject);
        }

    }

    public void UseFail_Drink()
    {
        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        AnswerWrong++;
        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum != 7 && oldNum != 4 && AnswerWrong != 3)
        {

            Instantiate(FailPanel[oldNum], canvas.transform, false);
            Destroy(gameObject);
            Debug.Log("false");

        }
        else if (oldNum != 7 && oldNum != 4 && AnswerWrong == 3)
        {
            Instantiate(GameOverPanel[oldNum], canvas.transform, false);
        }
        else if (oldNum != 7 && oldNum == 4 && AnswerWrong == 3)
        {
            Instantiate(GameOverPanel[8], canvas.transform, false);
        }
        else if (oldNum != 7 && oldNum == 4 && AnswerWrong != 3)
        {
            Instantiate(FailPanel[8], canvas.transform, false);
            Destroy(gameObject);
            Destroy(gameObject);
        }

    }

    public void UseWin_Medicine()
    {
        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum == 0 )
        {
            AnswerCorrect++;
            if (AnswerCorrect != 5)
            {
                Destroy(gameObject);
                Instantiate(WinPanel, canvas.transform, false);
            }
            else if (AnswerCorrect == 5)
            {
                Instantiate(GameOverPanel[9], canvas.transform, false);
            }

        }
        else 
        {
            AnswerWrong++;
            if (AnswerWrong != 3)
            {
                Destroy(gameObject);
                Instantiate(FailPanel[oldNum], canvas.transform, false);
            }
            else if (AnswerWrong == 3)
            {
                Instantiate(GameOverPanel[oldNum], canvas.transform, false);
            }


        }

    }

    public void UseWin_Clothing()
    {
        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum == 1)
        {
            AnswerCorrect++;
            if (AnswerCorrect != 5)
            {
                Destroy(gameObject);
                Instantiate(WinPanel, canvas.transform, false);
            }
            else if (AnswerCorrect == 5)
            {
                Instantiate(GameOverPanel[9], canvas.transform, false);
            }

        }
        else
        {
            AnswerWrong++;
            if (AnswerWrong != 3)
            {
                Destroy(gameObject);
                Instantiate(FailPanel[oldNum], canvas.transform, false);
            }
            else if (AnswerWrong == 3)
            {
                Instantiate(GameOverPanel[oldNum], canvas.transform, false);
            }


        }

    }

    public void UseWin_Bandage()
    {

        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum == 2)
        {
            AnswerCorrect++;
            if (AnswerCorrect != 5)
            {
                Destroy(gameObject);
                Instantiate(WinPanel, canvas.transform, false);
            }
            else if (AnswerCorrect == 5)
            {
                Instantiate(GameOverPanel[9], canvas.transform, false);
            }

        }
        else
        {
            AnswerWrong++;
            if (AnswerWrong != 3)
            {
                Destroy(gameObject);
                Instantiate(FailPanel[oldNum], canvas.transform, false);
            }
            else if (AnswerWrong == 3)
            {
                Instantiate(GameOverPanel[oldNum], canvas.transform, false);
            }


        }

    }

    public void UseWin_Can()
    {

        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum == 3)
        {
            AnswerCorrect++;
            if (AnswerCorrect != 5)
            {
                Destroy(gameObject);
                Instantiate(WinPanel, canvas.transform, false);
            }
            else if (AnswerCorrect == 5)
            {
                Instantiate(GameOverPanel[9], canvas.transform, false);
            }

        }
        else
        {
            AnswerWrong++;
            if (AnswerWrong != 3)
            {
                Destroy(gameObject);
                Instantiate(FailPanel[oldNum], canvas.transform, false);
            }
            else if (AnswerWrong == 3)
            {
                Instantiate(GameOverPanel[oldNum], canvas.transform, false);
            }


        }

    }

    public void UseWin_Water()
    {

        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum == 4)
        {
            AnswerCorrect++;
            if (AnswerCorrect != 5)
            {
                Destroy(gameObject);
                Instantiate(WinPanel, canvas.transform, false);
            }
            else if (AnswerCorrect == 5)
            {
                Instantiate(GameOverPanel[9], canvas.transform, false);
            }

        }
        else
        {
            AnswerWrong++;
            if (AnswerWrong != 3)
            {
                Destroy(gameObject);
                Instantiate(FailPanel[oldNum], canvas.transform, false);
            }
            else if (AnswerWrong == 3)
            {
                Instantiate(GameOverPanel[oldNum], canvas.transform, false);
            }


        }

    }

    public void UseWin_Flashlight()
    {

        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum == 5)
        {
            AnswerCorrect++;
            if (AnswerCorrect != 5)
            {
                Destroy(gameObject);
                Instantiate(WinPanel, canvas.transform, false);
            }
            else if (AnswerCorrect == 5)
            {
                Instantiate(GameOverPanel[9], canvas.transform, false);
            }

        }
        else
        {
            AnswerWrong++;
            if (AnswerWrong != 3)
            {
                Destroy(gameObject);
                Instantiate(FailPanel[oldNum], canvas.transform, false);
            }
            else if (AnswerWrong == 3)
            {
                Instantiate(GameOverPanel[oldNum], canvas.transform, false);
            }


        }

    }

    public void UseWin_Wallet()
    {

        canvas = GameObject.FindGameObjectWithTag("PanelCanvas");
        if (oldNum == 6)
        {
            AnswerCorrect++;
            if (AnswerCorrect != 5)
            {
                Destroy(gameObject);
                Instantiate(WinPanel, canvas.transform, false);
            }
            else if (AnswerCorrect == 5)
            {
                Instantiate(GameOverPanel[9], canvas.transform, false);
            }

        }
        else
        {
            AnswerWrong++;
            if (AnswerWrong != 3)
            {
                Destroy(gameObject);
                Instantiate(FailPanel[oldNum], canvas.transform, false);
            }
            else if (AnswerWrong == 3)
            {
                Instantiate(GameOverPanel[oldNum], canvas.transform, false);
            }


        }

    }


}
