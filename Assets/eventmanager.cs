using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventmanager : MonoBehaviour
{

    public GameObject[] events;
    bool eventActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(eventActive == false){
            Instantiate(events[Random.Range(0, events.Length)]);
            eventActive = true;
        }
    }
}
