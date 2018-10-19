using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    GameObject player;
    float speed = 10f;
    Rigidbody2D rb;
    Animator animator;

	// Use this for initialization
	void Start () {
        player = this.gameObject;
        rb = player.GetComponent<Rigidbody2D>();
        animator = player.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.A))
            {
                player.transform.localScale = new Vector3(-1, 1, 1);
            }
            if (Input.GetKey(KeyCode.D))
            {
                player.transform.localScale = new Vector3(1, 1, 1);
            }
            animator.SetBool("isRunning", true);
            player.transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0) * speed * Time.deltaTime);
        }
        else if (animator.GetBool("isRunning"))
        {
            animator.SetBool("isRunning", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, 10);
            animator.SetBool("isJumping", true);  
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("isJumping", false);
    }
}
