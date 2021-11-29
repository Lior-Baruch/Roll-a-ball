using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPonCollision : MonoBehaviour
{
    public GameObject PostProcessing;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PostProcessing.SetActive(true);
            gameObject.SetActive(false);
        }
    }

}
