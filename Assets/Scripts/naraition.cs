using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class naraition : MonoBehaviour {
    public TextAsset ta;
	// Use this for initialization
	void Start () {
        DialogManager.instance.SetText(ta);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
