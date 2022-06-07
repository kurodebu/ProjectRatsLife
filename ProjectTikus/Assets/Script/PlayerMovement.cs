﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController2D controller;
	private AudioSource source;
	public float runSpeed = 40f;
	
	float horizontalMove = 0f;
	bool jump = false; 
	public Animator animator;
	
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
		//horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		horizontalMove = SimpleInput.GetAxis("Horizontal") * runSpeed;
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
			animator.SetBool("isJumping", true);
			source.Play();
		}
    }

	public void Jump()
	{
		jump = true;
			animator.SetBool("isJumping", true);
			source.Play();
	}
	
	public void OnLanding ()
	{
		animator.SetBool("isJumping", false);
	}
	
	void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
		jump = false;
	}
}

