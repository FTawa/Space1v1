using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinConditionTracker : MonoBehaviour, Event
{
    //wincondition should be interface

    public List<Event> listEvents = new List<Event>();
    int winCondition = 100;
    private GameObject eventManager;
    public void onWinnerFound(){
        eventManager.GetComponent<eventmanager>().endEvent();
    }
    

    void Start()
    {
        StartCoroutine(SearchForEventManager());
    }

    IEnumerator SearchForEventManager()
    {
        while (eventManager == null)
        {
            eventManager = GameObject.FindGameObjectWithTag("EventManager");

            if (eventManager == null)
            {
                Debug.Log("Event Manager not found. Retrying...");
                yield return new WaitForSeconds(1.0f); 
            }
            else
            {
                Debug.Log("Event Manager found!");
                break;
            }
        }
    }


    void Update(){
            if(ScoreScript.scoreValue >= winCondition)
            {
                Debug.Log("You Win!");
                
                notifyWinnerFound();
                endEvent();
            }
    }


    public void addListerner(Event e){
        listEvents.Add(e);
    }
    void notifyWinnerFound(){
        foreach(Event e in listEvents){
            e.onWinnerFound();
        }
    }
    
  
}
