using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Transform player;
    private Vector3 direction;
    private float speed = 15;
    private float attackRange = 1f;
    private float distanceToPlayer;


    void Start()
    {
        player = GameObject.Find("Player Noobik").transform;
    }


    void Update()
    {
        distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer <= attackRange)
        {

            direction = (player.position - transform.position).normalized;

            transform.Translate(direction * Time.deltaTime * speed);
        }

    }
}
