using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        if (transform.position.y < -5)
        {
            transform.position = new Vector2(0, 0);
            rb.AddForce(new Vector2(-9f * -25f, -25f ));
        }
    }
}
