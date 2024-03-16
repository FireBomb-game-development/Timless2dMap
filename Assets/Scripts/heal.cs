using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;

public class heal : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] int HealValue;
    [SerializeField] GameObject timer;
  
    [SerializeField] CountdownTimer countdownTimer;
    public event Action<feedPlayer> OnItemClick;

    // Start is called before the first frame update
    void Awake()
    {
        CountdownTimer countdownTimer = timer.GetComponent<CountdownTimer>();

    }

    public void Heal()
    {
        CountdownTimer.HP = Mathf.Min(CountdownTimer.HP +10, 100);


    }
    public void OnPointerClick(PointerEventData action)
    {
        Debug.Log("Heal" + CountdownTimer.HP);

       Heal();

        Debug.Log("Heal" + CountdownTimer.HP);




    }
}
