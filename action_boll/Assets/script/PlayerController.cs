using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody2D rigidbody;
	public int dir = 1;
	public float speed = 2f;

	void Start(){
		rigidbody  = GetComponent<Rigidbody2D>();
	}

	void FixedUpdate(){
		move();	
	}

	void move(){
		float x = Input.GetAxis("Horizontal");

		if(x > 0){
			dir = 1;
		}else if(x < 0){
			dir = -1;
		}

		transform.localScale = new Vector3(dir, 1, 1);
		rigidbody.velocity = new Vector2(x * 10f, rigidbody.velocity.y);
	}

	void jump(){
		float y = Input.GetAxis("Vertical");

	}

}
