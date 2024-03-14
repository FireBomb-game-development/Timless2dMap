using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    [SerializeField] Vector3 minScale;
    [SerializeField] Vector3 maxScale;
    [SerializeField] Vector3 growScale;
    public bool IsEdible { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShrinkObj()
    {
        transform.localScale = minScale;
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.z <= maxScale.z)
        {
            IsEdible = false;
            transform.localScale += growScale*Time.fixedDeltaTime;
        }
        else
        {
            IsEdible = true;
        }
    }
}
