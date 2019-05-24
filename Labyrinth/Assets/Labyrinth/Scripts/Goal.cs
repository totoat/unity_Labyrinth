using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

     public GameObject goalUI;

    void Start () {
        goalUI.SetActive(false);
	}

    private void OnTriggerEnter(Collider other)
    {
        goalUI.SetActive(true);
    }
}
