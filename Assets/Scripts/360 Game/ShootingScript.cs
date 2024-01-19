using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class ShootingScript : MonoBehaviour
{
    [Header("Bullet Settings")]
    /*public GameObject bullet;
    public GameObject player;
    public int bulletspeed = 25;


    public float fireRate = 0.5f;
    private float nextFire = 6.0f;*/

    public GameObject playerref;
    
    public GameObject bullet;
    public Transform bulletpos;

    private float timer;
    public float nextfire = 1;
    public float firerate = 0.2f;

    CircularPath circularPath;

    //private GameObject player = GameObject.FindGameObjectsWithTag("Player");


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Time.time > nextFire)
        {
            if (!bullet)
                return;
            nextFire = Time.time + fireRate;
            GameObject clone = Instantiate(bullet, this.transform.position, this.transform.rotation);
            Rigidbody rb = clone.GetComponent<Rigidbody>();
            rb.AddRelativeForce(Vector3.forward * bulletspeed, ForceMode.Impulse);
        }*/
        timer+= Time.deltaTime;
        if(Time.time > nextfire)
        {
            //timer = 0;
            nextfire = Time.time + firerate;

            firebullet();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Coin Tag")
        {
            Destroy(collision.gameObject);
        }
    }

    void firebullet()
    {

        //Vector3 futurePosition = playerref.transform.position + playerref.GetComponent<Rigidbody2D>().velocity  * Time.deltaTime;
        // Instantiate the bullet just before the calculated future position
        GameObject temp1 = Instantiate(bullet, bulletpos.position, Quaternion.identity);
        Destroy(temp1, 0.5f);

       

        //GameObject temp1 = Instantiate(bullet, bulletpos.position, Quaternion.identity);
        //Destroy(temp1, 2f);
        //GameObject temp2 = Instantiate(bullet, temp1.transform.position, Quaternion.identity);
        //Destroy(temp2, 2f);
        // GameObject temp3 = Instantiate(bullet, bulletpos.position-new Vector3(1,0)*10, Quaternion.identity);
        //Destroy(temp3, 5f);

    }
    /*public void InstantiateBullet()
    {
        GameObject fired = Instantiate(bullet,transform.position,Quaternion.identity);

        Vector3 directionToPlayer = (player.transform.position - fired.transform.position).normalized;

        bullet.GetComponent<Rigidbody2D>().velocity = directionToPlayer * bulletspeed;

        Destroy(bullet,6);
    }*/



}
