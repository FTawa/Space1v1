using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eventmanager : MonoBehaviour
{

    public Text eventName;
    private float timeToAppear = 2f;
    private float timeWhenDisappear;
    public GameObject[] events;
    bool eventActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        startEvent();

        if(eventName.enabled && (Time.time >= timeWhenDisappear)){
            eventName.enabled = false;
        }
    }

    void startEvent(){
         if(eventActive == false){
            Instantiate(events[Random.Range(0, events.Length)]);
            eventActive = true;
            eventName.enabled = true;
            eventName.text = events[Random.Range(0, events.Length)].name;
            timeWhenDisappear = Time.time + timeToAppear;
        }
    }

}
