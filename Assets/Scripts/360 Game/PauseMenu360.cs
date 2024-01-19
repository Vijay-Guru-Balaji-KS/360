using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PauseMenu360 : MonoBehaviour
{
    public GameObject EndGameMenu;
    //CircularPath circular;

    public void displayPauseMenu()
    {
        EndGameMenu.SetActive(true);
    }

    public void goHome()
    {
        SceneManager.LoadScene("Main menu 360 Game");
    }

    public void restart()
    {
        SceneManager.LoadScene("360 Game");
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
