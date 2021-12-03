using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float maxRotateValue = 200;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().angularVelocity = Random.value * maxRotateValue; //Random range can also be used, random value has range from 0 to 1
    }
}
