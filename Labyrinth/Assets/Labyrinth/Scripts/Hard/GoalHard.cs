using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalHard : MonoBehaviour
{

    [SerializeField] GameObject GoalUI;

    AudioSource audioSource;
    [SerializeField] AudioClip clearFanfare;
    private bool alreadyGoal;

    void Start()
    {
        GoalUI.SetActive(false);
        alreadyGoal = false;

        audioSource = GetComponent<AudioSource>();
    }

    // ゴール時の処理
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Player")
        {
            if (!alreadyGoal)
            {
                GoalUI.SetActive(true);

                audioSource.PlayOneShot(clearFanfare);

                alreadyGoal = !alreadyGoal;
            }

        }

    }
}
