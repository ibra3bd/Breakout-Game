
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    Rigidbody2D rb2D;

    float HorizontalInput;
    [SerializeField] float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb2D.position += new Vector2(HorizontalInput * Time.deltaTime * speed, 0);
    }


}
