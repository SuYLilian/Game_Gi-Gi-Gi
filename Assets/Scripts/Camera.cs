using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject yellowRoomCam, pinkRoomCam, blueRoomCam, RightArrow, LeftArrow,nextLevelButton;
    public GameObject[] cross = new GameObject[7];
    float PosX = 15.76f;
    public static int room;
   

    public void Start()
    {

        room = 0;

    }
    
    

    public void RightMove()
    {

        if(room!=2)
        {

            room++;
            if (room == 1)
            {
               
                LeftArrow.SetActive(true);              
                yellowRoomCam.SetActive(false);
                pinkRoomCam.SetActive(true);
                blueRoomCam.SetActive(false);
                transform.position = new Vector3(transform.position.x + PosX, transform.position.y, -10);

            }
            else if (room == 2)
            {

                RightArrow.SetActive(false);
                yellowRoomCam.SetActive(false);
                pinkRoomCam.SetActive(false);
                blueRoomCam.SetActive(true);
                transform.position = new Vector3(transform.position.x + PosX, transform.position.y, -10);

            }

        }

    }

    public void LeftMove()
    {

        if(room!=0)
        {

            room--;
            if(room==1)
            {

                RightArrow.SetActive(true);
                yellowRoomCam.SetActive(false);
                pinkRoomCam.SetActive(true);
                blueRoomCam.SetActive(false);
                transform.position = new Vector3(transform.position.x - PosX, transform.position.y, -10);

            }
            else if(room==0)
            {

                LeftArrow.SetActive(false);
                yellowRoomCam.SetActive(true);
                pinkRoomCam.SetActive(false);
                blueRoomCam.SetActive(false);
                transform.position = new Vector3(transform.position.x - PosX, transform.position.y, -10);

            }

        }

    }

    public void NextLevel()
    {
        RightArrow.SetActive(false);
        LeftArrow.SetActive(false);
        yellowRoomCam.SetActive(false);
        pinkRoomCam.SetActive(false);
        blueRoomCam.SetActive(false);
        nextLevelButton.SetActive(false);

        for (int i=0;i<7;i++)
        {

            cross[i].SetActive(false);

        }

        transform.position = new Vector3(60, 0, -10);
        SecondLevel.isSecondLevel = true;

    }

}
