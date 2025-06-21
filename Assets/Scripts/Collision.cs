using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    [SerializeField] private CharacterController characterController;
    public float pushPower = 4;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic)
        {
            return;
        }

        Vector3 pushDirection = new Vector3 (hit.moveDirection.x, hit.moveDirection.y, hit.moveDirection.z);
        body.linearVelocity = pushDirection * pushPower;

    }
}
