using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Rigidbody2D rb;
    public float jumpVelocity = 1.0f;
    public float moveSpeed = 1f;
    

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        // var vel = new Vector2(Input.GetAxis("Horizontal"), 0);
        var y = 0.0f;
        if (Input.GetKey(KeyCode.Space)) {
            Debug.Log("Jump");
            y = jumpVelocity;
        }
        rb.AddForce(new Vector2(moveSpeed * Time.deltaTime, y * Time.deltaTime));
        
    }
}
