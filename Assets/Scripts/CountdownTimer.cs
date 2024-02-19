using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField ]public string levelToLoad;
    [SerializeField]private float timer;
    //private TextMeshProUGUI timerSecoends;
    // Start is called before the first frame update
    void Start()
    {
        //timerSecoends = GetComponent<TextMeshProUGUI>();   
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        //timerSecoends.text = timer.ToString("f0");
        if (timer <= 0)
        {
            Application.LoadLevel(levelToLoad);
        }
        
    }
}
