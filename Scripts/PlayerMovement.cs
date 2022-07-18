using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed, jumpHeight;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private float _movement;
    private void Update()
    {
        JumpCheck();
        _movement = Input.GetAxisRaw("Horizontal");
        if (_movement != 0)
        {
            transform.position = transform.position + new Vector3(_movement, 0, 0) * (speed * Time.deltaTime);
        }
    }

    private void JumpCheck()
    {
        if (!Input.GetKeyDown(KeyCode.Space) || !PlayerGeneral.IsGrounded()) return;
        PlayerGeneral.Change("isJumping", true);
        _rb.AddForce(Vector2.up * jumpHeight);
    }
}
