using UnityEngine;
using System.Collections;

public class MapMove : MonoBehaviour {
    float speed = 8f;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float deltaX = Input.GetAxis ("Horizontal");
        transform.Translate (Vector2.right* deltaX * speed * Time.deltaTime);
    }
}
