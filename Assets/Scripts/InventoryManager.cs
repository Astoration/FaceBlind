using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {
	public List<Item> itemList;
	public GameObject ContentBox;
	public GameObject itemBox;
   
	private const float itemBoxMargin = -10f;
	private const float itemBoxHeight = -180f;
	// Use this for initialization
	void Start () {
        this.gameObject.SetActive(false);
        int itemCount = 15;
		ContentBox.GetComponent<RectTransform>().sizeDelta = new Vector2(0,Mathf.Abs(itemBoxMargin*2 + itemBoxHeight * itemCount));
		for (int i = 0; i < itemCount; i++) {
			Image box = Instantiate (itemBox).GetComponent<Image>();
			box.rectTransform.parent = ContentBox.transform;
			box.rectTransform.anchoredPosition = new Vector2(0, itemBoxMargin + itemBoxHeight * i);
		}
	
	}
	
	// Update is called once per frame
	void Update () {

    }
}
