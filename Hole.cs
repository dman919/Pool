using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject cueBall;
    public Vector3 location;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Ball"))
        {
            if (collision.gameObject.name.Contains("Cue"))
            {
                Instantiate(cueBall, location, Quaternion.identity);
            }
            Destroy(collision.gameObject);
        }
    }
}