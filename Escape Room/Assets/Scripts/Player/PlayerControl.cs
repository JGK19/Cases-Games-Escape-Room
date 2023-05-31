using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D body;
    public float moveSpeed;
    private bool isMoving;
    private Vector2 input;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        
        
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
            if (input.x != 0) input.y = 0;
            if(input != Vector2.zero)
            {
                animator.SetFloat("MoveX", input.x);
                animator.SetFloat("MoveY", input.y);
                var targetPos = transform.position;
                targetPos.x += input.x;
                targetPos.y += input.y;
                StartCoroutine(Move(targetPos));
            }
        }

            
            if(input != Vector2.zero) { 
            animator.SetFloat("MoveX", input.x);
            animator.SetFloat("MoveY", input.y);
        }


        /*var targetPos = transform.position;
        targetPos.x += input.x;
        targetPos.y += input.y;*/

        body.velocity = input.normalized * moveSpeed; //* Time.fixedDeltaTime; não funciona por alguma razão quando multiplica pelo deltatime

                //StartCoroutine(Move(targetPos));
            
        if (input.x != 0 || input.y != 0) isMoving = true;
        if (input.x == 0 && input.y == 0) isMoving = false;


        animator.SetBool("isMoving", isMoving);

    }

    /*IEnumerator Move(Vector3 targetPos)
    {
        isMoving = true;
        while((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            yield return null;
        }
        isMoving = false;
    }*/
}
