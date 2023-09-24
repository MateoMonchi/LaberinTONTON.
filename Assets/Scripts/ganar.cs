using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ganar : MonoBehaviour
{

    void OnCollisionEnter(Collision collision2)
    {
        if (collision2.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("ganar");
        }
    }
}


