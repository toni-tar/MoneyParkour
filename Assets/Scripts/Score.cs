using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    private int count;
    public TextMeshProUGUI score;
    public AudioSource audio;
    void Start()
    {
        count = 0;
        score.text = "Score: " + count.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            audio.Play();
            count++;
            score.text = "Score: " + count.ToString();
            Destroy(collision.gameObject);
        }
    }

}
