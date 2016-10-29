using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ItemDetail : MonoBehaviour {
    public Text details;
    public GameObject image;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
	}

    public void SetData(string content, Sprite sp) {
        details.text = content;
        image.GetComponent<Image>().sprite = sp;

    }
}
