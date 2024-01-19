using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{
    public static int scoreValue = 0;
    public TMP_Text score;
    public TMP_Text gameover;
    int timer=600;


    // Update is called once per frame
    void Update()
    {
        score.text = "Score : " + scoreValue;
        if(timer < 0 )
        {
            gameover.text = "GAME OVER";
        }
        timer = timer - 1;
    }
}
