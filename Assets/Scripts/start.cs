using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class start : MonoBehaviour {
    public GameObject to;
    public GameObject[] close = new GameObject[2];
    public Text readyText;
    // Use this for initialization

    void Start()
    {

        StartCoroutine(ShowReady());         // ShowReady함수실행
    }

    IEnumerator ShowReady()                  //코루틴함수 코루틴은 나중에 설명
    {
        int count = 0;
        while (true)                    // 텍스트를 깜빡깜빡하게 만드는 소스
        {
            readyText.text="";
            yield return new WaitForSeconds(0.5f);
            readyText.text= "<ANY KEY TO START>";
            yield return new WaitForSeconds(0.5f);
            count++;
        }
    }
    // Update is called once per frame

    void Update () {
        for (int i = 0; i < 2; ++i) {
            close[i].transform.position = Vector3.MoveTowards(close[i].transform.position, to.transform.position, 0.5f);
         }
        if (Input.anyKeyDown) {
            Application.LoadLevel("sinobsis");
        }

	}
}
