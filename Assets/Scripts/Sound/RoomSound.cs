using UnityEngine;
using System.Collections;

public class RoomSound : MonoBehaviour {
    public AudioClip[] clip=new AudioClip[3];    //사운드 파일을 가진다
    public static RoomSound instance;//사운드매니저의 위치를 담는다

    AudioSource audio;                  //오디오 소스 컨퍼넌트를 담을준비를 한다.
    // Use this for initialization
    void Start()
    {
        audio = GetComponent<AudioSource>();// 오디오 컴퍼넌스를 담는다.
        StartCoroutine(soundMixer());
    }
    IEnumerator soundMixer()
    {
        while (true) {
            audio.PlayOneShot(clip[Random.Range(0, 3)]);
            yield return new WaitForSeconds(1.4f);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
    void Awake()
    {
        if (RoomSound.instance == null)
        {// 인스턴스가 비어있으면
            RoomSound.instance = this;   //이것의 인스턴스를 집어넣는다.
        }
    }


}
