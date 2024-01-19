using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPlacement : MonoBehaviour
{
    [Header("Coin Properties")]
    public GameObject Coin;
    public int numberofcoins = 10;
    public float radius = 6.6f;



    // Start is called before the first frame update
    void Start()
    {
        spawnCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public int countcoins()
    {
        return numberofcoins;
    }

    public void spawnCoins()
    {

        float totalArcLength = 10f * numberofcoins; // Total distance around the circle
        float angleIncrement = 360f * (10f / totalArcLength); // Calculate angle increment based on the desired distance

        for (int i = 0; i < numberofcoins; i++)
        {
            // Calculate the angle for each coin
            float angle = i * angleIncrement * Mathf.Deg2Rad;

            // Calculate the position of the coin along the circular path
            float x = Mathf.Cos(angle) * radius;
            float y = Mathf.Sin(angle) * radius;

            // Instantiate the coin at the calculated position
            Instantiate(Coin, new Vector3(x, y, 0f), Quaternion.identity);
        }
    }
}
