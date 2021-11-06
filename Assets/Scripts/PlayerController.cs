using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public Text CountText;
    public Text WinText;
    private Rigidbody rb;
    private int count;
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        WinText.text = "";
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        float moveUp = Input.GetKeyDown(KeyCode.Space) ? JumpForce : 0.0f;
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * Speed;
        movement += new Vector3(0.0f, moveUp, 0.0f);
        rb.AddForce(movement);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Pick Up"))
        {
            //other.gameObject.SetActive(false);
            //other.gameObject.
            count++;
            SetCountText();
            if(count >= 12)
            {
                WinText.text = "You WIN!\n we will update the game with more levels soon :D ";
            }
        }
    }

    private void SetCountText()
    {
        CountText.text = "count: " + count.ToString();
    }
}
