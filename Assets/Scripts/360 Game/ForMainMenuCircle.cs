using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForMainMenuCircle : MonoBehaviour
{
    [Header("Main Menu Settings")]
    public GameObject Player;
    public float radius = 4f;
    public float angle = 0f;
    public float speed = 4f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Cos(angle) * radius;
        float y = Mathf.Sin(angle) * radius;

        this.transform.position = new Vector3(x, y, 0);

        angle += speed * Time.deltaTime * 1;

        angle = Mathf.Repeat(angle, 2 * Mathf.PI);
    }
}
