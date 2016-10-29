using UnityEngine;
using System.Collections;

public class Potal : MonoBehaviour {
    public string scene;
	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.DownArrow)) {
            Application.LoadLevel(scene);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
