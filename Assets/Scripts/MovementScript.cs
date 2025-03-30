using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    //[SerializeField] 
    //private float acceleration = 75f;
    
    [SerializeField] 
    private float acceleration = 5000f;
    
    Rigidbody2D rb2d;
    
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
