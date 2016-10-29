using UnityEngine;
using System.Collections;

public class SetTimeImage : MonoBehaviour {
	public Sprite Day;
	public Sprite Night;
	private SpriteRenderer sprite;
	// Use this for initialization
	void Start () {
		sprite = GetComponent<SpriteRenderer> ();
		if (Days.instance.isNight)
			sprite.sprite = Night;
		else
			sprite.sprite = Day;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
