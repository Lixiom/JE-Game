using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrouchCollider : MonoBehaviour {
    CapsuleCollider2D m_Collider;

    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        m_Collider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //Toggle the Collider on and off when pressing the space bar
            m_Collider.enabled = !m_Collider.enabled;

            //Output to console whether the Collider is on or not
            Debug.Log("Collider.enabled = " + m_Collider.enabled);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            m_Collider.enabled = !m_Collider.enabled;
        }
    }
}
