//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

 
    public Rigidbody rb;

        // Use this for initialization
        public float fowardForce = 2000f;
        public float sideWaysForce = 500f;
	    void Start () {
        // rb.AddForce(0,200,500);
        
	    }
	
	// Update is called once per frame
	void FixedUpdate () {
       
       rb.AddForce(0, 0, fowardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0,fowardForce * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -fowardForce * Time.deltaTime);
        }

        if (rb.position.y < 0)
        {
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
