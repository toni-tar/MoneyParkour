using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject gameWin;
    public AudioSource audioWin;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            audioWin.Play();
                Debug.Log("Пельмени успешно переварил портал!!!!");
            gameWin.SetActive(true);
        }

    }
}
