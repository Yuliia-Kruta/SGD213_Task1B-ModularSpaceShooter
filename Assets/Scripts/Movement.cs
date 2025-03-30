using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float acceleration = 75f;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        rb2d.AddForce(direction * acceleration * Time.deltaTime);
    }
}