using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    GameObject player;
    float speed = 5f;
    Rigidbody2D rb;
    bool isJumping = false;
    KeyCode W, A, S, D;

	// Use this for initialization
	void Start () {
        player = this.gameObject;
        rb = player.GetComponent<Rigidbody2D>();
        if(player.name == "Player0")
        {
            W = KeyCode.W;
            A = KeyCode.A;
            S = KeyCode.S;
            D = KeyCode.D;
        }
        else
        {
            W = KeyCode.UpArrow;
            A = KeyCode.LeftArrow;
            S = KeyCode.DownArrow;
            D = KeyCode.RightArrow;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(A) || Input.GetKey(D))
        {
            if (Input.GetKey(A) && !Input.GetKey(D))
            {
                player.transform.localScale = new Vector3(-1, transform.localScale.y, transform.localScale.z);
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
            else if (Input.GetKey(D) && !Input.GetKey(A))
            {
                player.transform.localScale = new Vector3(1, transform.localScale.y, transform.localScale.z);
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }

        }
        if (Input.GetKeyDown(W) && !isJumping)
        {
            rb.velocity = new Vector2(rb.velocity.x,15);
            isJumping = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        isJumping = false;
    }
}
