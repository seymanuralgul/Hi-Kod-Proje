using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;
    bool zipla = true;
    Rigidbody2D rd2;
    float horizontal;
    Animator playerAnimator;
    bool turning = true;
    Vector3 scale;
    public float jumpAmount = 3f;
    

    void Start()
    {
        rd2 = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rd2.velocity.y,0))
        {
            rd2.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
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

    void turncharacter()
    {
        turning = !turning;
        scale = gameObject.transform.localScale;
        scale.x *= -1;
        gameObject.transform.localScale = scale;
    }
}
