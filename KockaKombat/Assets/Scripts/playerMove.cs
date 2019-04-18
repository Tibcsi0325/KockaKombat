using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    public Groundcheck gc;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float jump = 0f;
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        if (Input.GetKeyDown("space") && gc.isJumping)
            jump = jumpForce;

        rb.AddForce(new Vector2(move, jump));
    }


}
