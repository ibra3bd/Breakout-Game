using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reflects : MonoBehaviour
{

    


    Vector3 lastVelocity;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(9.8f * 25f, 9.8f * 25f));
    }
    private void Update()
    {
        

        rb = GetComponent<Rigidbody2D>();
        lastVelocity = rb.velocity;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, collision.contacts[0].normal);
        rb.velocity = direction * Mathf.Max(speed,0.0f);

        if(collision.gameObject.CompareTag("Bricks"))
        {
            Destroy(collision.gameObject);
        }

    }


}