using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    GameObject player;
    float speed = 0.3f;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        player = this.gameObject;
        rb = player.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        player.transform.Translate(new Vector3(Input.GetAxis("Horizontal"), 0, 0) * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(0, 10);
        }
    }
}
