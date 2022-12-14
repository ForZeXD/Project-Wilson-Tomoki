using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EngineerMovement : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }
}
