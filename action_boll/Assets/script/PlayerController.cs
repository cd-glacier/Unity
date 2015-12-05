using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rigidbody;
	public int dir = 1;
	private int isGround = 0;

	void Start(){
		rigidbody  = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate(){
		move();	
	}

	void OnCollisionEnter2D(Collision2D c){
		if(c.gameObject.tag == "ground"){
			isGround = 2;
		}
	}

	void move(){
		float x = Input.GetAxis("Horizontal");

		if(x > 0){
			dir = 1;
		}else if(x < 0){
			dir = -1;
		}

		transform.localScale = new Vector3(dir, 1, 1);
		rigidbody.velocity = new Vector2(x * 5f, rigidbody.velocity.y);

		if(Input.GetButtonDown("Jump")){
			if(isGround > 0){
				rigidbody.AddForce(Vector2.up * 200f);
				isGround--;
			}
		}
	}


}
