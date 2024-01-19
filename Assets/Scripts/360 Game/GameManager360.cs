using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager360 : MonoBehaviour
{
    public TextMeshProUGUI scoreref;
    
    public void IncreaseScore()
    {
        scoreref.text = (float.Parse(scoreref.text)+1f).ToString();
    }

    public int currentScore()
    {
        return int.Parse(scoreref.text);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
