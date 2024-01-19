using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class TargetMovement : MonoBehaviour
{
    public int point;
    //private GameManager gameManager;
    private Rigidbody rb;
    //public ParticleSystem explosion;

    // Start is called before the first frame update
    void Start()
    {
        //gameManager =GameObject.Find("GameManager").GetComponent<GameManager>();


        rb = GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(0, 1, 0) * Random.Range(10, 14), ForceMode.Impulse);
        rb.AddTorque(Random.Range(-8, 8), Random.Range(-8, 8), Random.Range(-8, 8), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(-4, -4),-6,0);
    }

    
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        ScoreScript.scoreValue += point;
        Destroy(gameObject);
        //gameManager.UpdateScore(point);
        //Instantiate(explosion,transform.position,explosion.transform.rotation);
    }
}
