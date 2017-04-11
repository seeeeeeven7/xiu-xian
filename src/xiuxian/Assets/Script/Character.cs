using System.Collections;
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
        //    if (!animator.GetBool("Falling"))
            {
                // 检查移动
                int horizontal = (int)(Input.GetAxisRaw("Horizontal"));
                if (horizontal != 0)
                {
          //          animator.SetBool("Walking", true);
                    if (horizontal > 0)
                    {
                        rigidbody2D.velocity = new Vector2(+5F, rigidbody2D.velocity.y);
                        spriteRenderer.flipX = false;
                    }
                    else
                    {
                        rigidbody2D.velocity = new Vector2(-5F, rigidbody2D.velocity.y);
                        spriteRenderer.flipX = true;
                    }
                }
                else
                {
                    rigidbody2D.velocity = new Vector2(0, rigidbody2D.velocity.y);
                    //animator.SetBool("Walking", false);
                }
            }

        }
    }
}
