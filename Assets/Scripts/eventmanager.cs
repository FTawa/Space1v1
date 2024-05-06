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
    public bool eventActive = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(eventActive == false){
            startEvent();
        }else{
            
        }

        if(eventName.enabled && (Time.time >= timeWhenDisappear)){
            eventName.enabled = false;
        }
    }

    void startEvent(){
            Instantiate(events[Random.Range(0, events.Length)]);
            eventActive = true;
            eventName.enabled = true;
            eventName.text = events[Random.Range(0, events.Length)].name;
            timeWhenDisappear = Time.time + timeToAppear;
    }

    public void endEvent(){
        //logic to go to next event
    }
}
