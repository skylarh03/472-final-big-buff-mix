using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeActiveTrigger : MonoBehaviour
{
    public GameObject triggerToEnable;
    
    void OnTriggerExit()
    {
        triggerToEnable.SetActive(true);
        gameObject.SetActive(false);
    }
}
