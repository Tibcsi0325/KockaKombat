using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovew : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        rb.AddForce(new Vector2(move,0));
    }
}
