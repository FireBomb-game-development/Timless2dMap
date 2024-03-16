using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RitryGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadGame()
    {
        SceneManager.LoadScene("open");
        Time.timeScale = 1f;
        CountdownTimer.HP =100;
    }
}
