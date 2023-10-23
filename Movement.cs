using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    float HorizontalMove = 0;
    bool edge = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the collision is with an edge of the map
        if (collision.gameObject.CompareTag("MapEdge"))
        {
            // Stop the rectangle from moving
            edge = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        // Reset the edge variable when the rectangle leaves the map edge
        if (collision.gameObject.CompareTag("MapEdge"))
        {
            edge = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
            HorizontalMove = Input.GetAxisRaw("Horizontal"); // this takes input to determin the direction it will be moving to
        
    }
    void FixedUpdate()
    {
        if (!edge)
        {

            if (HorizontalMove > 0) // if the object is moving to the right then we d the following code
            {
                transform.position += Vector3.right * Time.deltaTime * speed; // add on to the 
            }
            else if (HorizontalMove < 0)
            {
                transform.position += Vector3.left * Time.deltaTime * speed;
            }
        }
        
    }
}
