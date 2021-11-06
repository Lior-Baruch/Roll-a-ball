using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRandLocation : MonoBehaviour
{
    public float GroundSize;
    public float GroundMinX;
    public float GroundMinZ;

    private System.Random random;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 newLocation = getRandomLocation();
            gameObject.transform.position = newLocation;
        }
    }

    private Vector3 getRandomLocation()
    {
        random = new System.Random();
        float x, y, z;
        x = (float)(random.NextDouble() * (GroundSize) + GroundMinX);
        y = gameObject.transform.position.y;
        z = (float)(random.NextDouble() * (GroundSize) + GroundMinZ);

       return (new Vector3(x, y, z));
    }
}
