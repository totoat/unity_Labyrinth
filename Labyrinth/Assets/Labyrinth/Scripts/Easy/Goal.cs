using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

    public GameObject GoalUI;
    public Button NextButton;
    // アイコンText (TextComponentとしてではなくGameObjectとして取得)
    private GameObject IconNextOn;
    private GameObject IconNextOff;

    AudioSource audioSource;
    public AudioClip clearFanfare;

    void Start () {
        // Nextボタンの子オブジェクト
        IconNextOn = NextButton.transform.Find("IconNextOn").gameObject;
        IconNextOff = NextButton.transform.Find("IconNextOff").gameObject;

        GoalUI.SetActive(false);
        NextButton.interactable = false;
        IconNextOn.gameObject.SetActive(false);
        IconNextOff.gameObject.SetActive(true);

        audioSource = GetComponent<AudioSource>();
	}

    // ゴール時の処理
    private void OnTriggerEnter(Collider other)
    {
        GoalUI.SetActive(true);
        NextButton.interactable = true;
        IconNextOn.gameObject.SetActive(true);
        IconNextOff.gameObject.SetActive(false);

        audioSource.PlayOneShot(clearFanfare);
    }
}
