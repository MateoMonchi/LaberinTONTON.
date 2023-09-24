using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Puntos : MonoBehaviour
{
    public float punto;
    public Text textoPuntos;

    private void Update()
    {
        textoPuntos.text = "Puntos: " + punto.ToString();
    if(punto >= 8)
        {
            SceneManager.LoadScene("ganar");
        }
    }


}
