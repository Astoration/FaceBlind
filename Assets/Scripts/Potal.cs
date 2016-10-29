using UnityEngine;
using System.Collections;

public class Potal : MonoBehaviour {
    public string scene;
	public string direction;
	// Use this for initialization
	void Start () {
	
	}
    void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.DownArrow)) {
			Days.instance.spawnDirection = direction;
            Application.LoadLevel(scene);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
