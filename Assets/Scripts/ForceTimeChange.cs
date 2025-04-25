using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceTimeChange : MonoBehaviour
{
    public AK.Wwise.Event stateChangeEvent;
    
    public GameObject lightingObject;

    public TimeManager timeManager;

    public bool forceDaytime = false;
    public bool forceNighttime = false;

    private Color newLightingColor;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(forceDaytime);
        //Debug.Log(forceNighttime);
        if (forceDaytime)
        {
            newLightingColor = new Color(0.9966949f, 1f, 0.8726415f, 1f);
        }
        else if (forceNighttime)
        {
            newLightingColor = new Color(0.325564f, 0.2783464f, 0.4245283f, 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        if (forceDaytime && !timeManager.isDaytime)
        {
            //Debug.Log("trigger is working");
            timeManager.lightingObject.GetComponent<Light>().color = newLightingColor;

            if (forceDaytime && !timeManager.isDaytime)
            {
                //Debug.Log("forcing daytime");
                timeManager.isDaytime = true;
                timeManager.lightingColor = new Color(0.9966949f, 1f, 0.8726415f, 1f);
            }
            else if (forceNighttime && timeManager.isDaytime)
            {
                //Debug.Log("forcing nighttime");
                timeManager.isDaytime = false;
                timeManager.lightingColor = new Color(0.325564f, 0.2783464f, 0.4245283f, 1f);
            }
            timeManager.forceSwitchRemainder += timeManager.timeElapsed;
            timeManager.timeForcefullyChanged = true;
            stateChangeEvent.Post(gameObject);
            //Debug.Log("Time elapsed: " + timeManager.timeElapsed);
            //Debug.Log("Force switch remainder: " + timeManager.forceSwitchRemainder);
        }
        else if (forceNighttime && timeManager.isDaytime)
        {
            //Debug.Log("trigger is working");
            timeManager.lightingObject.GetComponent<Light>().color = newLightingColor;

            if (forceDaytime && !timeManager.isDaytime)
            {
                //Debug.Log("forcing daytime");
                timeManager.isDaytime = true;
                timeManager.lightingColor = new Color(0.9966949f, 1f, 0.8726415f, 1f);
            }
            else if (forceNighttime && timeManager.isDaytime)
            {
                //Debug.Log("forcing nighttime");
                timeManager.isDaytime = false;
                timeManager.lightingColor = new Color(0.325564f, 0.2783464f, 0.4245283f, 1f);
            }
            timeManager.forceSwitchRemainder += timeManager.timeElapsed;
            timeManager.timeForcefullyChanged = true;
            stateChangeEvent.Post(gameObject);
            //Debug.Log("Time elapsed: " + timeManager.timeElapsed);
            //Debug.Log("Force switch remainder: " + timeManager.forceSwitchRemainder);
        }
    }
}
