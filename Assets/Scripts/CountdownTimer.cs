using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class CountdownTimer : MonoBehaviour
{
    [SerializeField ]public string levelToLoad;
    [SerializeField]private float timer;
    [SerializeField]public static float HP =100;
    public static float maxHP =100;
    private float maxHunger =100;
    [SerializeField]private float hunger =100f;
    [SerializeField]private float hungerScale =0.1f;
    
    [SerializeField]private float timeToDie;

    
    [SerializeField]private TextMeshProUGUI  timerSecoends;



    // Start is called before the first frame update

   // public void Heal(int amunt){
   // HP = Mathf.Min( HP + amunt ,maxHP);
 //   }


      public void Eat(int amunt){
        Debug.Log("Eating");
    hunger = Mathf.Min( hunger + amunt ,maxHunger);
    }

    // Update is called once per frame
    void Update()
    {
        hunger -= hungerScale*Time.deltaTime;
        timer -= Time.deltaTime;
        timeToDie = timer*(hunger/maxHunger)*(HP/maxHP);
        timerSecoends.text = "Time: ";
        timerSecoends.text= timerSecoends.text.Insert(timerSecoends.text.Length-1,timeToDie.ToString("f1"));
        //Debug.Log(timerSecoends.text);
        if (timeToDie <= 0)
        { 
            Application.LoadLevel(levelToLoad);
        }
        
    }
}
