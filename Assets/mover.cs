using UnityEngine;

public class mover : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
            rb.linearVelocity = new Vector2(6, 0);
        
        if(Input.GetKey(KeyCode.LeftArrow))
            rb.linearVelocity = new Vector2(-6, 0);

        if(Input.GetKey(KeyCode.Space))
            rb.linearVelocity = new Vector2(0, 10);
    }

    void FixedUpdate()
    {

    }
}
