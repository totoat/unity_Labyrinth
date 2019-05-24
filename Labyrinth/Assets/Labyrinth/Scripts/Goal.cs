using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

     public GameObject goalUI;
    AudioSource audioSource;
    public AudioClip clearFanfare;

    void Start () {
        goalUI.SetActive(false);

        audioSource = GetComponent<AudioSource>();
	}

    private void OnTriggerEnter(Collider other)
    {
        goalUI.SetActive(true);
        audioSource.PlayOneShot(clearFanfare);
    }
}
