using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Switch : MonoBehaviour {
    public Sprite[] sp = new Sprite[2];
    private int a=1;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	}

    public void SwitchSprite() {
        this.gameObject.GetComponent<Image>().sprite = sp[a++%2];
    }
}
