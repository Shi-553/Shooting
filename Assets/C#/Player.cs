using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    new Rigidbody rigidbody;
    Transform cameraTransform;

    [SerializeField]
    float speed = 10.0f;
    [SerializeField]
    float moveForceMultiplier = 5.0f;

    Vector3 move;

    void Start() {
        rigidbody = GetComponent<Rigidbody>();
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update() {

        var forward = cameraTransform.forward;
        var right = cameraTransform.right;

        right.y = 0;
        right.Normalize();
        forward.y = 0;
        forward.Normalize();

        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");


        move = (forward * v + right * h).normalized * speed;

        if (move != Vector3.zero) {
            transform.rotation = Quaternion.LookRotation(move,Vector3.up);
        }
    }

    private void FixedUpdate() {
        rigidbody.AddForce(moveForceMultiplier * (move - rigidbody.velocity));

    }
}
