using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {

	public float Speed;

	public float jumpForce;

	Rigidbody2D rb;


	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float X = Input.GetAxis("Horizontal");

		rb.velocity = new Vector2(X* Speed,rb.velocity.y) ;


		if(Input.GetKeyDown(KeyCode.Space))
		{
			rb.AddForce(Vector2.up * jumpForce);
		}
	}
}
