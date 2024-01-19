using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using System;
using System.Data.SqlTypes;

public class GameManager : MonoBehaviour
{
    private int score;
    public TextMeshProUGUI scoreText;
    

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);

        IEnumerator spawnTarget()
        {
            while (true)
            {
                UpdateScore(5);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + score;
    }

   
    
    public void UpdateScore(int v)
    {
            score += v;
            Debug.Log(score);
    }
}
