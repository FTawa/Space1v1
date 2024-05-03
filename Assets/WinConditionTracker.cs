using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinConditionTracker : MonoBehaviour
{
    //wincondition should be interface

    public List<Event> listEvents = new List<Event>();
    float winCondition = 100;

    // Update is called once per frame

    public void addListerner(Event e){
        listEvents.Add(e);
    }
    void notifyWinnerFound(){
        foreach(Event e in listEvents){
            e.onWinnerFound();
        }
    }
    void Update()
    {
        if(ScoreScript.scoreValue >= winCondition)
        {
            Debug.Log("You Win!");
            notifyWinnerFound();
        }
    }
}
