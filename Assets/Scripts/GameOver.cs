using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lava"))
        {
            Debug.Log("�������� ��������� � ���� � �������((((");
            gameOver.SetActive(true);
        }

    }
}
