using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private int speed = 12;
    private float horizontal;
    private float vertical;
    private int rotationSpeed = 66;
    public Rigidbody Rigidbody;
    private int forse = 6;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * vertical);
        transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed * horizontal);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(Vector3.up * forse, ForceMode.Impulse);
        }

    }
}
