using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {
	float speed = 13f;
	float jumpPower = 1250f;
	private Rigidbody2D rigid;
	private SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		sprite = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		moveControll ();
	}
		
	void moveControll(){
		float deltaX = Input.GetAxis ("Horizontal");
		float deltaY = Input.GetAxis ("Vertical");
		transform.Translate (Vector2.right* deltaX * speed * Time.deltaTime);
        if (deltaX < 0) {
			sprite.flipX = true;
		} else if (deltaX > 0) {
			sprite.flipX = false;
		}
		if (Input.GetKeyDown(KeyCode.Space)&&rigid.velocity.y==0) {
			rigid.AddForce (Vector2.up * jumpPower);
		}
	}
}
