using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb;
    RaycastHit2D hit;
    float moveSpeed = 10;
    public LayerMask groundChesck;
    public float jumpforce;
    public LayerMask monsterLayer;
    public bool isPlayerWatchingRight;
    public SpriteRenderer IMG;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        IMG = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(moveSpeed *Input.GetAxis("Horizontal"),rb.velocity.y);
        if (Physics2D.Raycast(transform.position, Vector2.down, 2.5f, groundChesck)&& Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up* jumpforce,  ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.C))
    }   {
             if(Physics2D.Raycast(transform.position, Vector2.right, 2, monsterLayer)&& isPlayerWatchingRight)
             {
                    Debug.DrawRay(transform.position, Vector2.right* 2, Color.red);
             }
            if (Physics2D.Raycast(transform.position, Vector2.left, 2, monsterLayer) && isPlayerWatchingRight)
             {
                Debug.DrawRay(transform.position, Vector2.left * 2, Color.red);
               }
            }
            if(input.GetAxis("Horizontal")>0)
            {
                     isplayerWatchinRight = true;
                     IMG.flipx= false;  
            }
            if (input.GetAxis("Horizontal") < 0)
            {
                     isplayerWatchinRight = false; 
                     IMG.flipx = true;
            }
}
