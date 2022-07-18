using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PlayerGeneral : MonoBehaviour
{
    public static bool isGrounded, isJumping;
    public static void Change(string c, bool t)
    {
        switch (c)
        {
            case "isJumping":
                isJumping = t; break;
            case "isGrounded":
                isGrounded = t; break;
            default:
                break;
        }
    }
    public static bool IsJumping() => isJumping;
    public static bool IsGrounded() => isGrounded;
}
