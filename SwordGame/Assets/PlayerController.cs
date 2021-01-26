using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Animator animator;
    public Transform hp;
    public Transform redBar;
    public Transform sword;
    Vector3 scale;

    public Transform oppPlayer;
    public Animator oppAnimator;
    public LayerMask oppLayer;

    public enum Control
    {
       manual = 0,
       automatic = 1
    };
    public Control control;

    float hInput;
    float vInput;
    bool spaceInput;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        scale = transform.localScale;

        hInput = 0.0f;
        vInput = 0.0f;
        spaceInput = false;

        if (control == Control.automatic)
            InvokeRepeating("Attack", 0.0f, 3.0f);

    }

    // Update is called once per frame
    void Update()
    {
        if (control == Control.manual)
        {
            hInput = Input.GetAxis("Horizontal");
            vInput = Input.GetAxis("Vertical");
            spaceInput = Input.GetKeyDown(KeyCode.Space);
        }
        else if (control == Control.automatic)
        {
            SetInputs();
        }
        if ((hInput < 0.0f && transform.position.x <= -8.5f) || (hInput > 0.0f && transform.position.x > 8.5f))
            hInput = 0.0f;
        if ((vInput < 0.0f && transform.position.y <= -4.8f) || (vInput > 0.0f && transform.position.y >= 2.5f))
            vInput = 0.0f;
        Move(hInput, vInput, spaceInput);
    }

    void SetInputs()
    {
        if (oppPlayer != null)
        {
            Vector2 current = new Vector2(transform.position.x, transform.position.y);
            Vector2 target = new Vector2(oppPlayer.position.x, oppPlayer.position.y);
            Vector2 path = target - current;
            hInput = System.Math.Abs(path.x) < 1.2 ? 0.0f : path.normalized.x * 0.5f;
            vInput = path.normalized.y * 0.5f;
        }
    }

    void Attack()
    {
        spaceInput = true;
    }

    void Move(float hInput, float vInput, bool spaceInput)
    {
        float hPower = hInput * 2.0f;
        float vPower = vInput * 2.0f;
        if (hPower == 0.0f && vPower == 0.0f)
            animator.SetBool("isWalking", false);
        else
        {
            if (hPower != 0.0f)
            {
                float hDir = hPower > 0.0f ? -1.0f : 1.0f;
                transform.localScale = new Vector3(hDir * System.Math.Abs(scale.x), scale.y, scale.z);
            }
            transform.position += transform.right * hPower * Time.deltaTime;
            transform.position += transform.up * vPower * Time.deltaTime;
            animator.SetBool("isWalking", true);
        }
        if (spaceInput)
        {
            animator.SetTrigger("triggerAttack");
            this.spaceInput = false;
        }
    }

    void DestroyPlayer()
    {
        Destroy(sword.GetComponent<Rigidbody2D>());
        sword.position = new Vector3(-100.0f, -100.0f, -100.0f);
        Destroy(animator);
        hp.localScale = Vector3.zero;
        Destroy(hp.gameObject);
        Transform[] children = GetComponentsInChildren<Transform>();
        foreach (Transform child in children)
            child.gameObject.AddComponent<ChildController>();
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (oppAnimator != null && oppAnimator.GetCurrentAnimatorStateInfo(0).IsName("attack1") && collision.collider.IsTouchingLayers(oppLayer))
        {
            if (redBar.localScale.x > 0.0f)
                redBar.localScale = new Vector3(redBar.localScale.x - 0.625f, redBar.localScale.y, redBar.localScale.z);
            if (redBar.localScale.x <= 0.0f)
                DestroyPlayer();
        }
    }

}
