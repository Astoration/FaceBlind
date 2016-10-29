using UnityEngine;
using System.Collections;

public class PlayerControll : MonoBehaviour {
	float speed = 13f;
	float jumpPower = 1250f;
	private Rigidbody2D rigid;
	private SpriteRenderer sprite;
	private Animator animationControl;
	public GameObject camera;
	public float status = 0f;
	public bool CharacterTrigger = false;
	// Use this for initialization
	void Start () {
		rigid = GetComponent<Rigidbody2D> ();
		sprite = GetComponent<SpriteRenderer> ();
		animationControl = GetComponent<Animator> ();
		if (Days.instance.spawnDirection.Equals ("Left")) {
			camera.transform.position = GameObject.Find ("LeftCamera").transform.position;
			this.transform.position = GameObject.Find ("LeftPlayer").transform.position;
			status = -1f;
			CharacterTrigger = false;
		} else {
			camera.transform.position = GameObject.Find ("RightCamera").transform.position;
			this.transform.position = GameObject.Find ("RightPlayer").transform.position;
			CharacterTrigger = false;
			status = 1f;
		}
	}
	
	// Update is called once per frame
	void Update () {
		moveControll ();
	}
		
	void moveControll(){
		float deltaX = Input.GetAxis ("Horizontal");
		transform.Translate (Vector2.right* deltaX * speed * Time.deltaTime);
        if (deltaX < 0) {
			sprite.flipX = true;
			if(status != -1f && CharacterTrigger){
				camera.transform.Translate (Vector2.right* deltaX * speed * Time.deltaTime);
			}
		} else if (deltaX > 0) {
			sprite.flipX = false;
			if(status != 1f && CharacterTrigger){
				camera.transform.Translate (Vector2.right* deltaX * speed * Time.deltaTime);
			}
		}
		if (deltaX == 0) {
			animationControl.SetBool ("isMovement", false);
		} else {
			animationControl.SetBool ("isMovement", true);
		}
		if (Input.GetKeyDown(KeyCode.Space)&&Mathf.Abs(rigid.velocity.y)<0.4) {
			rigid.AddForce (Vector2.up * jumpPower);
		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.CompareTag ("characterTrigger"))
			CharacterTrigger = true;
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.CompareTag("characterTrigger"))
			CharacterTrigger = false;
	}
}
