using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public new GameObject gameObject;

    // Use this for initialization
    void Start () {
        gameObject = GameObject.Find("Image");
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

	}

    private void OnTriggerEnter(Collider other)
    {
        // Debug.Log("Goal!");
        gameObject.SetActive(true);
    }
}
