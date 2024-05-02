using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{   
    void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the colliding object has a specific tag
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreScript.scoreValue += 10;
            Debug.Log("collided");
            // Destroy this game object (the one with the script attached)
            Destroy(this.gameObject);
        }
    }
}

