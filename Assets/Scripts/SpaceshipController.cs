using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    // The speed at which the spaceship will move
    public float speed = 10.0f;

    private Transform m_transform;

    // The Rigidbody component of the spaceship
    private Rigidbody2D rb;

    void Start()
    {
        // Get the Rigidbody component of the spaceship
        rb = GetComponent<Rigidbody2D>();

        m_transform = this.transform;
    }

    //function for player to look at mouse pos
    private void LAmouse(){
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - m_transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        m_transform.rotation = rotation;
    }

    void Update()
    {

        LAmouse();
        // Check if the left mouse button is pressed
        if (Input.GetMouseButton(0))
        {
            // Get the position of the mouse
            Vector3 mousePos = Input.mousePosition;

            // Calculate the direction from the spaceship to the mouse position
            Vector3 direction = Camera.main.ScreenToWorldPoint(mousePos) - transform.position;

            // Normalize the direction
            direction.Normalize();

            // Apply a force in the direction of the mouse drag
            rb.AddForce(direction * speed);
        }
    }
}