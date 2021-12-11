using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Rigidbody2D rb;
    public Vector2 velocity = Vector2.zero;
    public Transform contact;
    public LayerMask lm;
    public bool isGrounded = true;
    public float contactRadius;
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnDrawGizmos() {

    }
    void Update() {
        isGrounded = Physics2D.OverlapCircle(contact.position, 1.1f, this.lm);
        if(isGrounded && Input.GetButtonDown("Jump")){
            rb.velocity = new Vector2(0, rb.velocity.y + 20.0f);
        }
    }

}
