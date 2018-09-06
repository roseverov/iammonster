using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingScript : MonoBehaviour {

    //Speed of main hero
    public Vector3 speed = new Vector3(0, 0, 0);
    public float speedRotation = 3.0f;
    private Vector3 mousePosition;

    // Use this for initialization
    void Start () {
        Debug.Log("MovingScript is starting");
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        Rotation();
    }

    void Movement()
    {
        Vector3 position = transform.position;

        speed.x = Input.GetAxis("Horizontal");
        speed.y = Input.GetAxis("Vertical");

        transform.position = position + speed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Hit the floor");
    }

    void Rotation()
    {
        
    }
}
