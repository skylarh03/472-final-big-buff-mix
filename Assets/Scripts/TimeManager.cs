using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float timeThreshold = 60;
    public float timePassed = 0;
    public float timeElapsed = 0;
    [HideInInspector]
    public float timeChangeNum = 0;
    [HideInInspector]
    public float forceSwitchRemainder = 0;

    public GameObject lightingObject;

    //public GameObject timeTextObject;
    //private TMP_Text timeText;

    public bool isDaytime = true;
    private bool timeSwitched = false;
    [HideInInspector]
    public bool timeForcefullyChanged = false;

    public Color lightingColor;

    public AK.Wwise.Event naturalDaytime;
    public AK.Wwise.Event naturalNighttime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //timeText = timeTextObject.GetComponent<TextMeshProUGUI>();
        lightingColor = lightingObject.GetComponent<Light>().color;
    }

    // Update is called once per frame
    void Update()
    {
        timePassed = Mathf.Floor(Time.time);
        //Debug.Log(timePassed);
        //timeText.text = "Time passed: " + timePassed;
        //Debug.Log(timeElapsed);
        //Debug.Log(forceSwitchRemainder);
        //Debug.Log(timeChangeNum);
        //Debug.Log(timeForcefullyChanged);

        if (!timeForcefullyChanged)
        {
            timeElapsed = timePassed - (timeThreshold * timeChangeNum);
            //Debug.Log(timeElapsed);

            if (timeElapsed % timeThreshold == 0 && !timeSwitched && timePassed != 0)
            {
                //Debug.Log("math isn't mathing. " + timeElapsed % timeThreshold);
                if (isDaytime)
                {
                    //Debug.Log("it is nighttime");
                    lightingColor = new Color(0.325564f, 0.2783464f, 0.4245283f, 1f);
                    isDaytime = false;
                }
                else
                {
                    //Debug.Log("it is daytime");
                    lightingColor = new Color(0.9966949f, 1f, 0.8726415f, 1f);
                    isDaytime = true;
                }
                timeSwitched = true;
                lightingObject.GetComponent<Light>().color = lightingColor;
                timeChangeNum += 1;
            }
            else if (timeElapsed % timeThreshold == 1)
            {
                //Debug.Log("setting timeSwitched to false");
                timeSwitched = false;
            }
            else if (timeElapsed % timeThreshold == timeThreshold - 28)
            {
                if (isDaytime)
                {
                    naturalNighttime.Post(gameObject);
                }
                else
                {
                    naturalDaytime.Post(gameObject);
                }
            }
        }
        else
        {
            timeElapsed = timePassed - (timeThreshold * timeChangeNum) - forceSwitchRemainder;
            //Debug.Log("Time elapsed: " + timeElapsed);
            //Debug.Log("Force change time remainder: " + forceSwitchRemainder);
            //Debug.Log("running timeForcefullyChanged else");
            //Debug.Log("timeElapsed % timeThreshold: " + timeElapsed % timeThreshold);
            //Debug.Log("timeSwitched: " + timeSwitched);
            //Debug.Log("timeElapsed: " + timeElapsed);
            //Debug.Log("timeThreshold: " + timeThreshold);

            if (timeElapsed % timeThreshold == 0 && !timeSwitched && timeElapsed != 0)
            {
                //Debug.Log("math isn't mathing. " + timeElapsed % timeThreshold);
                if (isDaytime)
                {
                    //Debug.Log("it is nighttime");
                    lightingColor = new Color(0.325564f, 0.2783464f, 0.4245283f, 1f);
                    isDaytime = false;
                    lightingObject.GetComponent<Light>().color = lightingColor;
                }
                else
                {
                    //Debug.Log("it is daytime");
                    lightingColor = new Color(0.9966949f, 1f, 0.8726415f, 1f);
                    isDaytime = true;
                    lightingObject.GetComponent<Light>().color = lightingColor;
                }
                timeSwitched = true;
                timeChangeNum += 1;
                //Debug.Log("Time elapsed: " + timeElapsed);
                //Debug.Log("Force switch remainder: " + forceSwitchRemainder);
            }
            else if (timeElapsed % timeThreshold == 1)
            {
                //Debug.Log("setting timeSwitched to false");
                timeSwitched = false;
                //Debug.ClearDeveloperConsole();
            }
        }
    }

    // use FixedUpdate for lighting color crossfades
    void FixedUpdate()
    {
        if (isDaytime)
        {
            if (timeThreshold - timeElapsed <= 50 && timeThreshold - timeElapsed >= 25) //evening colors (0.8301887f, 0.6085561f, 0.246707f, 1f) - daytime colors (0.9966949f, 1f, 0.8726415f, 1f)
            {
            //Debug.Log("crossfade happening");
                lightingColor.r -= 0.00013320496f;
                lightingColor.g -= 0.00031315512f;
                lightingColor.b -= 0.0005007476f;
                lightingObject.GetComponent<Light>().color = lightingColor;
            }

            if (timeThreshold - timeElapsed <= 25) //nighttime colors (0.325564f, 0.2783464f, 0.4245283f, 1f)
            {
            //Debug.Log("crossfade part 2");
                lightingColor.r -= 0.00040369976f;
                lightingColor.g -= 0.00026416776f;
                lightingColor.b += 0.00014225704f;
                lightingObject.GetComponent<Light>().color = lightingColor;
            }
        }
        else
        {
            if (timeThreshold - timeElapsed <= 50)
            {
                lightingColor.r += 0.00026845236f;
                lightingColor.g += 0.00028866144f;
                lightingColor.b += 0.00017924528f;
                lightingObject.GetComponent<Light>().color = lightingColor;
            }
        }
    }
}
