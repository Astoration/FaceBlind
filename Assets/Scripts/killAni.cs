using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class killAni : MonoBehaviour {
    public Sprite[] sp = new Sprite[7];
	// Use this for initialization
	void Start () {
        StartCoroutine(ani());
	}
    IEnumerator ani()
    {
        for(int i=0; i<7; ++i){
                     this.GetComponent<SpriteRenderer>().sprite = sp[i];
                yield return new WaitForSeconds(0.7f);
            
        }
    }
    // Update is called once per frame
    void Update () {
	    
	}
}
