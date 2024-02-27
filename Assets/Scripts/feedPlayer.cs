using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class feedPlayer : MonoBehaviour , IPointerClickHandler
{
    [SerializeField] int feedingValue;
    [SerializeField] GameObject timer;
    [SerializeField] CountdownTimer countdownTimer;
    public event Action<feedPlayer> OnItemClick;

    // Start is called before the first frame update
    void Awake()
    {
       CountdownTimer countdownTimer = timer.GetComponent<CountdownTimer>();
        
    }

    public void Feed()
    {
        countdownTimer.Eat(feedingValue);
        

    }
    public void OnPointerClick(PointerEventData action)
    {
        Debug.Log("item presssd");
        Feed();

    }
}
