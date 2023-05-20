using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRB;

    [SerializeField]private float jumpForce = 1000f;
    [SerializeField]private float speed = 1000f;
    [SerializeField] private float runningSpeed = 2f;
   
    [SerializeField]private LayerMask groundMask;

    Vector3 startPosition;



    private void Awake()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        startPosition = this.transform.position;
    }

    public void StartGame()
    {
        this.transform.position = startPosition;
        this.playerRB.velocity = Vector2.zero;
    }

    private void Update()
    {
        Debug.DrawRay(this.transform.position, Vector2.down * 2.0f, Color.red);

    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Jump();
        }

        if(playerRB.velocity.x < runningSpeed)
        {
            playerRB.velocity = new Vector2(runningSpeed, playerRB.velocity.y);
        }

        //float horizontalMovement = Input.GetAxis("Horizontal");
        //Vector2 movement = new Vector2(horizontalMovement,0f);
        //layerRB.velocity = movement * speed * Time.deltaTime;
    }

    void Jump()
    {
        if(IsTouchingTheGround())
        {
            playerRB.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }

    bool IsTouchingTheGround()
    {
        if(Physics2D.Raycast(this.transform.position, Vector2.down, 2.0f, groundMask))
        {
            
            return true;
        }
        else
        {
            
            return false;
        }
    }

    public void Die()
    {
        // Animaciones die
        GameManager.sharedInstance.GameOver();
    }
}
