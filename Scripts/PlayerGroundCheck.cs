using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    public LayerMask groundLayer;
    public float groundCheckDistance;

    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, groundLayer);
        if (hit.collider != null)
        {
            PlayerGeneral.Change("isGrounded", true);
            PlayerGeneral.Change("isJumping", false);
        }
        else PlayerGeneral.Change("isGrounded", false);
    }
}
