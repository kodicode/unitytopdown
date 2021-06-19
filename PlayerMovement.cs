using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public Class PlayerMovement : MonoBehaviour
{
	public float speed = 8f;
	private Rigidbody2D rb;
	private Vector2 moveInput;
	private Vector2 moveVelocity;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput.normalized * speed;
	}

	void FixedUpdate()
	{
		rb.movePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
	}
}