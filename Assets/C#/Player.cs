using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    new Rigidbody rigidbody;
    Transform cameraTransform;

    [SerializeField]
    float speed = 10.0f;
    [SerializeField]
    float moveForceMultiplier = 5.0f;

    Vector3 move;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        var forward = cameraTransform.forward;
        var right = cameraTransform.right;

        right.y = 0;
        right.Normalize();
        forward.y = 0;
        forward.Normalize();

        if (Input.GetKey(KeyCode.W)) {
            dir += forward;
        }
        if (Input.GetKey(KeyCode.A)) {
            dir += -right;
        }
        if (Input.GetKey(KeyCode.S)) {
            dir += -forward;
        }
        if (Input.GetKey(KeyCode.D)) {
            dir += right;
        }
        dir.Normalize();

        move = dir * speed;

    }

    private void FixedUpdate() {
        rigidbody.AddForce(moveForceMultiplier * (move - rigidbody.velocity));

    }
}
