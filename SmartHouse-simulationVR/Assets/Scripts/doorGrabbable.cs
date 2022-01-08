using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class doorGrabbable : Throwable
{
    public Transform handler;

    public override void OnDetachedFromHand(Hand hand)
    {
        base.OnDetachedFromHand(hand);

        transform.position = handler.transform.position;
        transform.rotation = handler.transform.rotation;

        rigidbody.velocity = Vector3.zero;
        rigidbody.angularVelocity = Vector3.zero;
    }
}
