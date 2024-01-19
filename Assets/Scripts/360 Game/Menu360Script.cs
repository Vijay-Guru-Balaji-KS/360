using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu360Script : MonoBehaviour
{
    public static Menu360Script instance;

    LogicScript logic;

    public GameObject QuitPanel;
    public TextMeshProUGUI mainpageScore;


    private void Awake()
    {
        //PlayerPrefs.SetString("LeaderScore", "-1");
        PlayerPrefs.SetString("Finals","0");
    }


    // Start is called before the first frame update
    void Start()
    {
        if (logic != null)
        {
            int temp = logic.getScore();
            Debug.Log("Menu360 la score at start method : " + temp);
            mainpageScore.text = temp.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            QuitPanel.SetActive(true);
        }

        
    }

    private void LateUpdate()
    {
        mainpageScore.text = PlayerPrefs.GetString("BloodyScore");
    }


    public void displayQuit()
    {
          QuitPanel.SetActive(true);
    }

    public void confirmclose()
    {
        Application.Quit();
    }

    public void confirmnotclose()
    {
        QuitPanel.SetActive(false);
    }

    public void toPlay()
    {
        SceneManager.LoadScene("360 Game");
    }
}
