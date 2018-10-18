using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    GameObject player;
    float speed = 0.1f;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        player = this.gameObject;
        rb = player.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(player.transform.up * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Translate(player.transform.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Translate(-player.transform.right * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(-player.transform.up * speed);
        }
    }
}
