using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    KeyCode attack;
    KeyCode spell;
	// Use this for initialization
	void Start () {
        if (transform.parent.name == "Player0")
        {
            attack = KeyCode.X;
            spell = KeyCode.C;
        }
        else if (transform.parent.name == "Player1")
        {
            attack = KeyCode.O;
            spell = KeyCode.P;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Player" && collision != transform.parent && Input.GetKeyDown(attack))
        {
            Player ennemie = (Player) collision.GetComponent(typeof(Player));
            ennemie.TakeDamages(10f);
        }
    }
}
