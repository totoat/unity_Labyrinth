using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class surinukebousi : MonoBehaviour {

    public new Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(1,0,1);
        rigidbody.AddForce(new Vector3(0,-10,0));
	}
}
