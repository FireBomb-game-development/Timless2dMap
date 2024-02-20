using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField ]public string levelToLoad;
    [SerializeField]private float timer;
    private Text timerSecoends;
    // Start is called before the first frame update
    void Start()
    {
        timerSecoends = GetComponent<Text>();   
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSecoends.text = "Time: ";
        timerSecoends.text= timerSecoends.text.Insert(timerSecoends.text.Length-1,timer.ToString("f1"));
        Debug.Log(timerSecoends.text);
        if (timer <= 0)
        { 
            Application.LoadLevel(levelToLoad);
        }
        
    }
}
