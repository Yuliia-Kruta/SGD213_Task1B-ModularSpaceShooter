using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedController : MonoBehaviour
{
    [SerializeField] 
    private Vector2 direction;
    
    [SerializeField]
    private Vector2 velocityDirection;
    
    private MovementScript movementScript;


    // Use this for initialization
    void Start()
    {
        movementScript = GetComponent<MovementScript>();
        movementScript.AddVelocity(velocityDirection);
    }

    // Update is called once per frame
    void Update()
    {
        movementScript.Move(direction);
    }
}
