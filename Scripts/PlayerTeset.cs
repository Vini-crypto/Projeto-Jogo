using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeset : MonoBehaviour
{
	public float speed;
	private Rigidbody2D rb;
	private float inputHorizontal;
	private float inputVertical;
	public float distance;
	public LayerMask whatIsLadder;
	private bool isClimbing;
	
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
		rb.velocity = new Vector2(inputHorizontal * speed, rb.velocity.y);
		
		RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, Vector2.up, distance, whatIsLadder);
			
			if(hitInfo.collider != null){
				if(Input.GetKeyDown(KeyCode.UpArrow)){
					isClimbing = true;
				}
			} else{
				isClimbing = false;
			}
			
			if(isClimbing == true && hitInfo.collider != null){
				inputVertical = Input.GetAxisRaw("Vertical");
				rb.velocity = new Vector2(rb.position.x, inputVertical * speed);
				rb.gravityScale = 0;
			} else{
				rb.gravityScale = 5;
			}
    }
}
