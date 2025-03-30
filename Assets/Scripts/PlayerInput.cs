using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private MovementScript movementScript;

    void Start()
    {
        movementScript = GetComponent<MovementScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0.0f)
        {
            movementScript.Move(Vector2.right * horizontalInput);
        }
    }
}