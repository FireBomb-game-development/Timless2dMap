using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {

        Debug.Log("enemy script: ");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log(" HP "+ CountdownTimer.HP);
            CountdownTimer.HP = Mathf.Max(CountdownTimer.HP - 10, 0);
            Debug.Log(" HP " + CountdownTimer.HP);

        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
