using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalHard : MonoBehaviour
{

    public GameObject GoalUI;

    AudioSource audioSource;
    public AudioClip clearFanfare;

    void Start()
    {
        GoalUI.SetActive(false);

        audioSource = GetComponent<AudioSource>();
    }

    // ゴール時の処理
    private void OnTriggerEnter(Collider other)
    {
        GoalUI.SetActive(true);

        audioSource.PlayOneShot(clearFanfare);
    }
}
