using UnityEngine;
using System.Collections;

public class SwitchManager : MonoBehaviour {
    public GameObject[] go = new GameObject[3];
    public GameObject[] tem = new GameObject[3];
    private bool[] check= new bool[3];

	// Use this for initialization
	void Start () {
        check[0]=false;
        check[1] = false;
        check[2] = false;

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.M)) {
            go[0].GetComponent<Switch>().SwitchSprite();
            check[0] = true;
            tem[0].gameObject.SetActive(!tem[0].gameObject.active);

            if (check[1])
            {
                check[1] = false;
                go[1].GetComponent<Switch>().SwitchSprite();
                tem[1].gameObject.SetActive(!tem[1].gameObject.active);
            }
            if (check[2])
            {
                check[2] = false;
                go[2].GetComponent<Switch>().SwitchSprite();
                tem[2].gameObject.SetActive(!tem[2].gameObject.active);

            }
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            go[1].GetComponent<Switch>().SwitchSprite();
            tem[1].gameObject.SetActive(!tem[1].gameObject.active);
            check[1] = true;
            if (check[0])
            {
                go[0].GetComponent<Switch>().SwitchSprite();
                tem[0].gameObject.SetActive(!tem[0].gameObject.active);
                check[0] = false;
            }
            if (check[2])
            {
                go[2].GetComponent<Switch>().SwitchSprite();
                tem[2].gameObject.SetActive(!tem[2].gameObject.active);
                check[2] = false;
            }
        }
        else  if (Input.GetKeyDown(KeyCode.N))
        {
            go[2].GetComponent<Switch>().SwitchSprite();
            check[2] = true;
            tem[2].gameObject.SetActive(!tem[2].gameObject.active);
            if (check[0])
            {
                go[0].GetComponent<Switch>().SwitchSprite();
                tem[0].gameObject.SetActive(!tem[0].gameObject.active);
                check[0] = false;
            }
            if (check[1])
            {
                go[1].GetComponent<Switch>().SwitchSprite();
                check[1] = false;
                tem[1].gameObject.SetActive(!tem[1].gameObject.active);
            }
        }
    }
}
