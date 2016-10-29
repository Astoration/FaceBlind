using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public static Inventory instance;

	public List<Item> itemList = new List<Item>();
	// Use this for initialization
	void Start () {
		if (Inventory.instance == null) {
			Inventory.instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
