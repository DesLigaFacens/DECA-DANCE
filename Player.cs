using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public int movespeed;
    private float direction;
    private SpriteRenderer spriteRenderer;
    public bool floor;
    public Transform detectfloor;
    public LayerMask wfloor;
    public float jumpforce;

    void Start()
    {
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //detectando o chão pro pulo com um circulo invisivel
        floor = Physics2D.OverlapCircle(detectfloor.position, 0.2f, wfloor);
        
        //pulando
        if(Input.GetButtonDown("Jump") && floor == true){
            rb.velocity = Vector2.up * jumpforce;
            floor = false;
        }
        
        
        direction = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(direction * movespeed,rb.velocity.y);

        //flip do personagem
        if (direction > 0){
            spriteRenderer.flipX = false;
            
        }
        else if(direction < 0){
            spriteRenderer.flipX=true;
        }

        float realspeed = Mathf.Abs(direction) + Mathf.Abs(movimentoVertical);
    }
}
