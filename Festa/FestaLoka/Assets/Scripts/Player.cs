using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float directionx;
    public float directiony;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        directionx = Input.GetAxis("Horizontal");
        directiony = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(directionx * speed, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, directiony * speed);
    }
}
