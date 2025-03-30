using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovementScript playerMovementScript;

    private ShootingScript shootingScript;

    // Start is called before the first frame update
    void Start()
    {
        playerMovementScript = GetComponent<PlayerMovementScript>();
        shootingScript = GetComponent<ShootingScript>();
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");
        if (HorizontalInput != 0.0f)
        {
            playerMovementScript.HorizontalMovement(HorizontalInput);
        }

        if (Input.GetButton("Fire1"))
        {
            if (shootingScript != null)
            {
                shootingScript.Shoot();
            }
            
        }
    }
}