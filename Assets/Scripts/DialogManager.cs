using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour {
	float time = 0.1f;
	public Text Dialog;
    public AudioClip typing;    //사운드 파일을 가진다
    public static DialogManager instance;//사운드매니저의 위치를 담는다

    AudioSource audio;
    IEnumerator textReading(string text){
		string stringStack = "";
		for (int i = 0; i < text.Length+1; i++) {
			stringStack = text.Substring (0, i);
			Dialog.text = stringStack;
            audio.PlayOneShot(typing);
			yield return new WaitForSeconds (0.1f);
		}
	}
    void Awake()
    {
        if (DialogManager.instance == null)
        {// 인스턴스가 비어있으면
            DialogManager.instance = this;   //이것의 인스턴스를 집어넣는다.
        }
    }
    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();// 오디오 컴퍼넌스를 담는다.
        StartCoroutine (textReading ("마하라반야밀다심경관세음보살"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
