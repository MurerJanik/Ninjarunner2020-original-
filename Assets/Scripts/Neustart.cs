using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Neustart : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Debug.Log("Spieler tot");

            SceneManager.LoadScene("scene00");
        }
        else
            Debug.Log("Es ist nicht der Spieler");
    }

}
