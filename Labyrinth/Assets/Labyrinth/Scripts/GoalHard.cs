using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalHard : MonoBehaviour
{

    [SerializeField] GameObject GoalUI;

    AudioSource audioSource;
    [SerializeField] AudioClip clearFanfare;

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
