using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject gameObject1;
    public GameObject gameObject2;
    public GameObject gameObject3;
    public Transform spawnArea;
    public Vector2 spawnAreaMin;
    public Vector2 spawnAreaMax;

  

    void Start() {

  

    StartCoroutine(SpawnGameObjects());
    }
        //randomly spawn game objects
        IEnumerator SpawnGameObjects() {
        while (true) {
            // Calculate the x and y coordinates for the random position within the spawn area
            float x = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
            float y = Random.Range(spawnAreaMin.y, spawnAreaMax.y);

            // Create a vector to store the random position
            Vector2 spawnPosition = new Vector2(x, y);

            // Choose a random game object to spawn
            int randomIndex = Random.Range(1, 3);
            GameObject gameObjectToSpawn;

            // Set the game object to spawn based on the random index
            if (randomIndex == 1) {
                gameObjectToSpawn = gameObject1;
            } else if (randomIndex == 2) {
                gameObjectToSpawn = gameObject2;
            } else {
                gameObjectToSpawn = gameObject3;
            }

            float randomVelocity = Random.Range(3.0f, 15.0f);
            gameObjectToSpawn.GetComponent<Rigidbody2D>().velocity = new Vector2(randomVelocity, randomVelocity);

            // Spawn the game object at the random position
            Instantiate(gameObjectToSpawn, spawnPosition, Quaternion.identity, spawnArea);

            // Wait for a random number of seconds between 5 and 10 before spawning the next game object
            float randomDelay = Random.Range(1.0f, 2.0f);
            yield return new WaitForSeconds(randomDelay);


        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
