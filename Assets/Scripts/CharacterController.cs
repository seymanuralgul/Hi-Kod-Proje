using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;
    bool zipla = true;
    public float jumpForce;
    Rigidbody2D rd2;
    float horizontal;
    Animator playerAnimator;
    bool turning = true;
    Vector3 scale;
    

    void Start()
    {
        rd2 = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) && zipla == true))
        {
            rd2.velocity = Vector2.zero;
            rd2.AddForce(new Vector2(0,jumpForce));
            zipla = false;
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            GetComponent<AudioSource>().Play();
        }
    }
    
    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rd2.velocity = new Vector2(horizontal * Time.deltaTime * speed, rd2.velocity.y);
        playerAnimator.SetFloat("Speed", Mathf.Abs(horizontal));
        
        if(horizontal>0 && turning== false)
        {
            turncharacter();
        }
        if(horizontal<0 && turning == true)
        {
            turncharacter();
        }
    }

    private void OnCollissionEnter2D(Collision2D colission)
    {
        if (colission.transform.CompareTag ("Platform"))
        {
            zipla = true;
        }
    }

    void turncharacter()
    {
        turning = !turning;
        scale = gameObject.transform.localScale;
        scale.x *= -1;
        gameObject.transform.localScale = scale;
    }
}
