using UnityEngine;
using System.Collections;

public class InMapPortal : MonoBehaviour {
	public GameObject portalPoint;
	public GameObject camera;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.DownArrow)) {
			col.gameObject.transform.position = portalPoint.transform.position;
			Vector3 pos = camera.transform.position;
			pos.x = portalPoint.transform.position.x;
			camera.transform.position = pos;
		}
	}
}
