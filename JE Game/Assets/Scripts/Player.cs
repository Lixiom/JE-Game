using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {



	// Use this for initialization
	void Start () {
    
	// Update is called once per frame

        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Sword"))
            {
                other.gameObject.SetActive(false);
                haveSword = true;
            }
        }

