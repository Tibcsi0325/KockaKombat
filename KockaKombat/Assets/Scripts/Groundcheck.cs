using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Groundcheck : MonoBehaviour
{
    public bool isJumping;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isJumping = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isJumping = true;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isJumping = false;
    }






}
