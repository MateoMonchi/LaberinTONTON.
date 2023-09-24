using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject ObjPuntos;
    public float PuntosQueDa;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ObjPuntos.GetComponent<Puntos>().punto += PuntosQueDa;
            Destroy(gameObject);
        }
    }
}
