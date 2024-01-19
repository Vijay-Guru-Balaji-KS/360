using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;


public class CircularPath : MonoBehaviour
{
    public LogicScript logic;
    LogicScript lscript;

    [Header("Player & Shooter")]
    public GameObject player;
    public GameObject shooter;

    public float speed = 5f;
    public float radius = 5f;

    public float angle = 0f;

    public bool isClockwise = false;

    public int circleCount = 0;
    public int anticlock = 0;

    private int collectedcount = 0;

    [Header("Bullet Settings")]
    public GameObject bulletPrefab;
    public float bulletSpeed = 50f;

    [Header("Coin Alignement")]
    public bool isfull = true;
    public CoinPlacement placement;

    [Header("Shooting Script")]
    public ShootingScript ShootingScript;

    [Header("Score Settings")]
    public GameManager360 GameManager360;
    //public TextMeshProUGUI tempScore;
    public TextMeshProUGUI mudscore;
    int hscore = 0;

    [Header("Events settings")]
    public UnityEvent regardingscore;
    public PauseMenu360 p360;
    public bool isOut;

    
    /* public delegate void MyEventHandler();
     public static event MyEventHandler onConditionMet;*/





    // Start is called before the first frame update
    void Start()
    {
        isOut = false;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        lscript = logic.GetComponent<LogicScript>();
        hscore = int.Parse(PlayerPrefs.GetString("BloodyScore"), 0);
        mudscore.text = PlayerPrefs.GetString("BloodyScore");
        //tempScore.text = PlayerPrefs.GetString("LeaderScore");
    }

    // Update is called once per frame
    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isClockwise = !isClockwise;
        }

        float direction = (isClockwise ? 1 : -1);

        float x = Mathf.Cos(angle)*radius;
        float y = Mathf.Sin(angle)*radius;  

        this.transform.position = new Vector3(x, y, 0);

        angle+=speed*Time.deltaTime*direction;

        angle = Mathf.Repeat(angle,2*Mathf.PI);

        if (isClockwise && angle <= 0.01f && angle >= -0.01f)
        {
            circleCount++;            
        }
        else if (!isClockwise && Mathf.Approximately(angle, 2 * Mathf.PI))
        {
            anticlock++;
        }


        if(collectedcount==placement.GetComponent<CoinPlacement>().numberofcoins)
        {
            placement.GetComponent<CoinPlacement>().spawnCoins();
            collectedcount = 0;
        }

       /* if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetString("BloodyScore", "0");
        }*/
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin Tag")
        {
            collectedcount++;
            //Debug.Log("Coin collected");
            Destroy(collision.gameObject);
            regardingscore.Invoke();
        }

        if(collision.gameObject.tag =="Bullet Tag")
        {
            //Debug.Log("Bullet Hit");

            Destroy(gameObject);
            isOut = true;
        }

        if(isOut)
        {
            //InvokeConditionMet();
            //int afterscore = GameManager360.GetComponent<GameManager360>().currentScore();
            /*if (int.Parse(PlayerPrefs.GetString("LeaderScore")) < afterscore)
            {
                tempScore.text = afterscore.ToString();
                PlayerPrefs.SetString("LeaderScore", afterscore.ToString());
                    PlayerPrefs.Save();
            }*/
            ShootingScript.enabled = false;
            p360.GetComponent<PauseMenu360>().displayPauseMenu();

            int score = lscript.getScore();
            if(hscore<score)
            {
                PlayerPrefs.SetString("BloodyScore",score.ToString());
                mudscore.text = PlayerPrefs.GetString("BloodyScore");
                //Menu360Script.GetComponent<Menu360Script>().mainpageScore.text = PlayerPrefs.GetString("BloodyScore");
                Menu360Script.instance.GetComponent<Menu360Script>().mainpageScore.text = PlayerPrefs.GetString("BloodyScore");
                PlayerPrefs.Save();
            }
            
            
        }
    }

    
    /*public void InvokeConditionMet()
    {
        if(onConditionMet!=null)
        { 
            onConditionMet.Invoke();
        }
    }*/

    /*void InstantiateBullet()
    {
        // Instantiate bullet at the center of the circle
        GameObject bullet = Instantiate(bulletPrefab, shooter.transform.position, Quaternion.identity);

        // Calculate direction from the center to the player
        Vector3 directionToPlayer = (player.transform.position - shooter.transform.position).normalized;

        // Set bullet's velocity in the calculated direction
        bullet.GetComponent<Rigidbody2D>().velocity = directionToPlayer * bulletSpeed;

        Destroy(bullet, 6);
    }*/
}
