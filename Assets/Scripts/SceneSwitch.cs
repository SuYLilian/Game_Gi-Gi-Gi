using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch : MonoBehaviour
{
   public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void BackTitle()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        SecondLevel.isSecondLevel = false;
        SecondLevel.isGameOver = false;
        SecondLevel.oldNum = 0;
        SecondLevel.num = 0;
        SecondLevel.AnswerCorrect = 0;
        SecondLevel.AnswerWrong = 0;

    }

    public void QuitGame()
    {

        Application.Quit();

    }
}
