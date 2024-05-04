using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateLine : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        GameObject parent; 
        parent = transform.parent.gameObject;
        // Check if the colliding object has a specific tag
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreScript.scoreValue += 10;
            Debug.Log("collided");
            // Destroy this game object (the one with the script attached)
            Destroy(this.gameObject);
            Destroy(parent);
        }
    }
}
