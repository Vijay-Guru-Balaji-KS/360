using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletScript : MonoBehaviour
{
    private GameObject Player;
    private Rigidbody2D rb;
    public float force=10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag("Player");

        //Vector3 direction = Player.transform.position - transform.position;
        Vector3 direction = Player.transform.position +(Vector3) Player.GetComponent<Rigidbody2D>().velocity * Time.deltaTime;
        //below work
        rb.velocity =  new Vector2(direction.x * 2,direction.y) + new Vector2(direction.x*4,direction.y).normalized*force;

        //rb.velocity = new Vector2(direction.x * Random.RandomRange(1,3), direction.y) + new Vector2(direction.x *3, direction.y).normalized * force;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
