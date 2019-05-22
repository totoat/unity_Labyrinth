using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float adRotate = 100;
    private float zRotate = 0;
    private float xRotate = 0;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            xRotate = Mathf.Clamp(xRotate + adRotate*Time.deltaTime,-30,30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            xRotate = Mathf.Clamp(xRotate - adRotate*Time.deltaTime,-30,30);
            transform.eulerAngles = new Vector3(xRotate,0,zRotate);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
        }

    }
}
