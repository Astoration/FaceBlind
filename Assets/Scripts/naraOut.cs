using UnityEngine; 
using System.Collections;

public class naraOut : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(DialogManager.instance.i + "  " + DialogManager.instance.texts.Length);
        if (DialogManager.instance.i == DialogManager.instance.texts.Length) {
            Application.LoadLevel("MapOne");
        }
	}
}
