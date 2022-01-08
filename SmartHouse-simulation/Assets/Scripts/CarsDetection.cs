using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsDetection : MonoBehaviour
{
    public Animator animator;

    public AudioSource hornSFX;
    public AudioSource SFX;

    Vector3 PreviousFramePosition = Vector3.zero; 
    float Speed = 0f;

    void Update()
    {
        float movementPerFrame = Vector3.Distance(PreviousFramePosition, transform.position);
        Speed = movementPerFrame / Time.deltaTime;
        PreviousFramePosition = transform.position;

        if(Speed > 10)
        {
            SFX.Play();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        animator.speed = 0;

        if (other.CompareTag("Player"))
        {
            if (Speed > 10)
            {
                hornSFX.Play();
            }
            SFX.Stop();
        }
    }

    void OnTriggerExit(Collider other)
    {
        SFX.Play();
        animator.speed = 1;
    }
}
