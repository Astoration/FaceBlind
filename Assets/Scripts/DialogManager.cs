using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {
	float time = 0.1f;
	public Text Dialog;

	IEnumerator textReading(string text){
		string stringStack = "";
		for (int i = 0; i < text.Length; i++) {
			stringStack = text.Substring (0, i);
			Dialog.text = stringStack;
			yield return new WaitForSeconds (0.1f);
		}
	}

	// Use this for initialization
	void Start () {
		StartCoroutine (textReading ("마하라반야밀다심경관세음보살"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
