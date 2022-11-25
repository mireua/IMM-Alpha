using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public GameStatus status;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double pos = player.position.z + 423.9; 
        string poss = pos.ToString("0");
        if (poss == "163"){
            scoreText.text = "You win!";
        } else if (status.gameStatus == 0) {
            scoreText.text = "You lose!";
        } else {
            scoreText.text = poss;
        }
    }
}
