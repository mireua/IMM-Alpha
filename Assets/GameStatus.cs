using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    public int gameStatus = 1;
    public Score score;

    public void EndStatus()
    {
        if(gameStatus == 1){
            gameStatus = 0;
            //temp logging for game being finished
        }
    }

    public void WinStatus()
    {
        if(gameStatus == 1){
            gameStatus = 0;
        }
    }

}
