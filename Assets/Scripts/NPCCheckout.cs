using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class NPCCheckout : MonoBehaviour {
	public TextAsset comment;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player") && Input.GetKeyDown (KeyCode.Space)) {
			DialogManager.instance.SetText (comment);
		}
	}
}
