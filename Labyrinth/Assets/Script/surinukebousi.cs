using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Surinukebousi : MonoBehaviour {

    private new Rigidbody rigidbody;
    public AudioClip don;
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(1,0,1);
        rigidbody.AddForce(new Vector3(0,-10,0));
	}

    private void OnCollisionEnter(Collision collision)
    {
        audioSource.PlayOneShot(don);
    }
}
