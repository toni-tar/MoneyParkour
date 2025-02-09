using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    public AudioSource audioLose;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            audioLose.Play();
            Debug.Log("пельмени сварились в лаве и сгорели((((");
            gameOver.SetActive(true);
        }

    }
}
