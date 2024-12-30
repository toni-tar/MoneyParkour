using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject gameWin;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Portal"))
        {
            Debug.Log("Пельмени успешно переварил портал!!!!");
            gameWin.SetActive(true);
        }

    }
}
