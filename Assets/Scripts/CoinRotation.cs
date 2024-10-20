using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour
{

    private int rotationSpeed = 70;  
    
    void Update()
    {
        transform.Rotate(Vector3.left * Time.deltaTime * rotationSpeed);
    }
}
