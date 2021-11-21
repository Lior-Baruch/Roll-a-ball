using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float m_Speed;
    public float m_JumpForce;
    public int m_Score;
    private Rigidbody m_rb;
   
    // Start is called before the first frame update
    void Start()
    {
        m_rb = GetComponent<Rigidbody>();
        m_Score = 0;
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveUp = Input.GetKeyDown(KeyCode.Space) ? m_JumpForce : 0.0f;
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * m_Speed;
        movement += new Vector3(0.0f, moveUp, 0.0f);
        m_rb.AddForce(movement);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pick Up"))
        {
            m_Score++;
        }
    }
}
