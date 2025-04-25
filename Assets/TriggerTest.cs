using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    public GameObject timeManager;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        Debug.Log("trigger entered");

        //adjust timeManager variables
    }
    
    void OnTriggerExit()
    {
        Debug.Log("trigger exited");
    }
}
