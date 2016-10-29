using UnityEngine;
using System.Collections;

public class InvenVisibleManager : MonoBehaviour {
    public GameObject inven;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.I) == true)
        {
            inven.gameObject.SetActive(!inven.gameObject.active);
      
        }
    }
}
