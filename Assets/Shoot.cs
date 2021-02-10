using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shoot : MonoBehaviour
{
    int speed = 50;
    public Rigidbody bullet;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.forward * speed);
        }

    }
}
