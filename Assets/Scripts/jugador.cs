using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jugador : MonoBehaviour
{
    public float rapidez = 5f;

    Vector3 inicio;
    public Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        inicio = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.forward * rapidez * Time.deltaTime);
      }
       else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.back * rapidez * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.right * rapidez * Time.deltaTime);
        }
      else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.left * rapidez * Time.deltaTime);
        }
        if (RB.position.y < -500)
        {
            transform.position = inicio;
        }
    }

    private void OnCollisionEnter(Collision colision)
    {
        if (colision.gameObject.CompareTag("muerte"))
        {
            SceneManager.LoadScene("Scena");
        }
    }
}
