﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    private Animator animator;
    private Rigidbody2D rigidbody2D;
    private SpriteRenderer spriteRenderer;

    // Use this for initialization
    void Start () {

        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {

        // 攻击
        if (Input.GetButtonDown("Fire1"))
        {
          //  animator.SetTrigger("Attack");
        }
        // 跳跃
        if (Input.GetButtonDown("Jump"))
        {
            
            if (!animator.GetBool("Falling"))
            {
                animator.SetBool("Falling", true);
                rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, rigidbody2D.velocity.y + 5);
            }
           
        }
        else
        {
            int maxMoveSpeed = 7;
        //    if (!animator.GetBool("Falling"))
            {
                // 检查移动
                int horizontal = (int)(Input.GetAxisRaw("Horizontal"));
                int vertical = (int)(Input.GetAxisRaw("Vertical"));

                float moveSpeed = maxMoveSpeed;
                if (horizontal != 0 && vertical != 0)
                {
                    moveSpeed = moveSpeed / Mathf.Sqrt(2);
                }
                if (horizontal != 0)
                {
                    if (horizontal > 0)
                    {
                        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
                    }
                    else
                    {
                        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
                    }
                }
                if (vertical != 0)
                {
                    if (vertical > 0)
                    {
                        transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
                    }
                    else
                    {
                        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
                    }
                }
            }

        }
    }
}
