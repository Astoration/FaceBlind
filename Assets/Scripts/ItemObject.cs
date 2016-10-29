﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class ItemObject : MonoBehaviour {
	public Item items = new Item();
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Getitem(){
		Inventory.instance.itemList.Add (items);
	}

	void OnConllisionStay2D(Collider2D other){
		if (other.gameObject.CompareTag ("Player") && Input.GetKeyDown (KeyCode.Space)) {
			Getitem ();
		}
	}
}
