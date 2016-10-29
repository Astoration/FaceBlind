using UnityEngine;
using System.Collections;

public class MapTrigger : MonoBehaviour {
	public float direction = 1f;
	public GameObject player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float height = 2f * Camera.main.orthographicSize;
		float width = height * Camera.main.aspect;
		transform.localPosition = new Vector3 (direction * (width / 2f), 0, 0);

	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.CompareTag("wall"))
			player.GetComponent<PlayerControll> ().status = direction;
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if(other.CompareTag("wall"))
			player.GetComponent<PlayerControll> ().status = 0;
	}
}
