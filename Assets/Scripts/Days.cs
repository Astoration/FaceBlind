using UnityEngine;
using System.Collections;

public class Days : MonoBehaviour {
	public static Days instance;
	public int date = 1;
	public bool isNight=false;
	public string spawnDirection = "Left";
	public TextAsset[] assets = new TextAsset[10];
	public bool[] CheckList = new bool[4];
	// Use this for initialization
	void Awake () {
		if (Days.instance == null) {
			Days.instance = this;
			for (int i = 0; i < CheckList.Length; i++)
				CheckList [i] = false;
			DontDestroyOnLoad (this.gameObject);
		} else {
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
