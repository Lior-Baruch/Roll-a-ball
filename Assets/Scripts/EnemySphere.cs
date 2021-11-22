using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySphere : MonoBehaviour
{
    public float ForcePower;
    public int MaxForceX;
    public int MaxForceY;
    public int MaxForceZ;
    public float IntervalTime;
    private Rigidbody m_rb;
    private float timeSinceLastInterval;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        timeSinceLastInterval = 0;
    }

    private void FixedUpdate()
    {
        timeSinceLastInterval += Time.fixedDeltaTime;
        if (timeSinceLastInterval >= IntervalTime)
        {
            timeSinceLastInterval = 0;
            moveToRandDiraction();
        }
    }

    private void moveToRandDiraction()
    {
        float xForce = UnityEngine.Random.Range(-MaxForceX, MaxForceX);
        float yForce = UnityEngine.Random.Range(-MaxForceY, MaxForceY);
        float zForce = UnityEngine.Random.Range(-MaxForceZ, MaxForceZ);
        m_rb.AddForce(new Vector3(xForce, yForce, zForce));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * ForcePower);
        }
    }
}
