using UnityEngine;
using System.Collections;
using UnityEngine.Serialization;

public class PlayerMovementScript : MonoBehaviour
{
    // SerializeField exposes this value to the Editor, but not to other Scripts!
    // It is "pseudo public"
    // acceleration indicates how fast we accelerate Horizontally
    [SerializeField] private float acceleration = 5000f;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        // Get OurRigidbodyComponent once at the start of the game and store a reference to it
        // This means that we don't need to call GetComponent more than once! This makes our game faster. (GetComponent is SLOW)
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    public void HorizontalMovement(float HorizontalInput)
    {
        Vector2 ForceToAdd = Vector2.right * HorizontalInput * acceleration * Time.deltaTime;
        rb2d.AddForce(ForceToAdd);
    }
}