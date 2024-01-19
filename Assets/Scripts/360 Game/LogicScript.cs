using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogicScript : MonoBehaviour
{
    public TextMeshProUGUI scoretext;


    public int getScore()
    {
        int temp = int.Parse(scoretext.text);
        PlayerPrefs.SetString("PlayingScore",temp.ToString());
        PlayerPrefs.Save();
        return temp;
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
