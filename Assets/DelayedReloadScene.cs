using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DelayedReloadScene : MonoBehaviour
{
    void OnTriggerEnter()
    {
        StartCoroutine(wait());
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(9);

        Debug.Log("reload scene");
        SceneManager.LoadScene("Town");
    }
}
