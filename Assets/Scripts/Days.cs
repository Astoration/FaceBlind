using UnityEngine;
using System.Collections;

public class Days : MonoBehaviour {
	public static Days instance;
	public int date = 1;
	public string spawnDirection = "Left";
	// Use this for initialization
	void Awake () {
		if (Days.instance == null) {
			Days.instance = this;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
