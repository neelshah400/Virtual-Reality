using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordManScript : MonoBehaviour
{
    
    Animator animator;

    enum Direction
    {
        Left = -1,
        Right = 1
    };

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movePower = Input.GetAxis("Horizontal");
        if (movePower == 0.0f)
            animator.SetBool("running", false);
        else
        {
            Direction dir = movePower > 0.0f ? Direction.Right : Direction.Left;
            transform.localScale = new Vector3(-1 * (int) dir, 1, 1);
            transform.position += transform.right * (float) dir * Time.deltaTime * 2.0f;
            animator.SetBool("running", true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
            animator.SetTrigger("attack");

    }

}
