using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public int health = 100;
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("circle")){
            Debug.Log("circle");
        }
        if(collision.gameObject.CompareTag("box")){
            Debug.Log("box");
        }
        if(collision.gameObject.CompareTag("capsule")){
            Debug.Log("capsule");
        }
    }
}
 