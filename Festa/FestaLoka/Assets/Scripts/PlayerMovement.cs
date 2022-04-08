using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;

    private Rigidbody2D rb;

    Vector2 movement;

    void Update() => MovementInput();

    private void FixedUpdate() {
        Rb.velocity = Movement;
    }
    void MovementInput () {
        float mx = Input.GetAxisRaw("Horizontal");
        float my = Input.GetaxiRaw("Vertical");

        Movement = new Vector2(mx, my).normalized;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
