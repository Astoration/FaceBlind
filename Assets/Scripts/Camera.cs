using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {
	public GameObject player;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = player.transform.position;
		Vector3 cpos = this.GetComponent<Camera> ().transform.position;
		float x = pos.x - 6;
		float y = cpos.y;
		this.transform.Translate (new Vector3( x,y,0));
	}
}
