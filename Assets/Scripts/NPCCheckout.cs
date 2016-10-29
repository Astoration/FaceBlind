using UnityEngine;
using System.Collections;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class NPCCheckout : MonoBehaviour {
	public TextAsset[] comment = new TextAsset[10];
	public TextAsset[] secondComment = new TextAsset[10];
	public bool[] options = new bool[10];
	public bool[] secondOption = new bool[10];
	public bool isSecond = false;
	public bool[] dateList = new bool[10];
	// Use this for initialization
	void Start () {
		if(dateList[Days.instance.date-1] == false)
			this.gameObject.SetActive (false);
		GetComponent<BoxCollider2D> ().isTrigger = true;
		GetComponent<Rigidbody2D> ().isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player") && Input.GetKeyDown (KeyCode.Space)) {
			if (comment [Days.instance.date] != null) {
				if (secondComment [Days.instance.date] != null && isSecond) {
					DialogManager.instance.SetText (secondComment [Days.instance.date - 1]);
					if (secondOption [Days.instance.date - 1])
						Days.instance.addTime ();
				} else {
					DialogManager.instance.SetText (comment [Days.instance.date - 1]);
					isSecond = true;
					if (options [Days.instance.date - 1])
						Days.instance.addTime ();
				}
			}
		}
	}
}
