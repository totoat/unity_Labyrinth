using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float adRotate = 100;
    float zRotate = 0;
    float xRotate = 0;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        /*   //入力情報
           float turn = Input.GetAxis("Horizontal");
           //現在の回転角度を0～330から-180～180に変換
           float rotateZ = (transform.eulerAngles.z > 180) ? transform.eulerAngles.z - 330 : transform.eulerAngles.z;
           // 現在の回転角度に入力(turn)を加味した回転角度をMathf.Clamp()を使いminAngleからMaxAngle内に収まるようにする
           float angleZ = Mathf.Clamp(rotateZ + turn * speed, minAngle, maxAngle);
           // 回転角度を-180～180から0～330に変換
           angleZ = (angleZ < 0) ? angleZ + 330 : angleZ;
           // 回転角度をオブジェクトに適用
           transform.rotation = Quaternion.Euler(0, angleZ, 0);
          */

        /*
                if (Input.GetKey(KeyCode.A)){
                    //transform.Rotate(new Vector3(0, 0, 1));
                    transform.Rotate(new Vector3(0, 0, 1), Space.World);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    transform.Rotate(new Vector3(0, 0, -1), Space.World);
                }
                if (Input.GetKey(KeyCode.W))
                {
                    //transform.Rotate(new Vector3(1, 0, 0));
                    transform.Rotate(new Vector3(1, 0, 0) ,Space.World);
                }
                if (Input.GetKey(KeyCode.S))
                {
                    //transform.Rotate(new Vector3(-1, 0, 0));
                    transform.Rotate(new Vector3(-1, 0, 0),Space.World);
                }
         */

        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            xRotate = Mathf.Clamp(xRotate + adRotate*Time.deltaTime,-30,30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            /*
            if (System.Math.Abs(xRotate) + System.Math.Abs(zRotate) >=30)
            {
                xRotate = Mathf.Clamp(xRotate + adRotate * Time.deltaTime, -30, 30);
                if (zRotate>=0)
                {
                    zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -30, 30);
                }
                else
                {
                    zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, -30, 30);
                }
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            else
            {
                xRotate = Mathf.Clamp(xRotate + adRotate * Time.deltaTime, -30, 30);
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            */
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            xRotate = Mathf.Clamp(xRotate - adRotate*Time.deltaTime,-30,30);
            transform.eulerAngles = new Vector3(xRotate,0,zRotate);
            /*
            if (System.Math.Abs(xRotate) + System.Math.Abs(zRotate) >= 30)
            {
                xRotate = Mathf.Clamp(xRotate - adRotate * Time.deltaTime, -30, 30);
                if (zRotate >= 0)
                {
                    zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -30, 30);
                }
                else
                {
                    zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, -30, 30);
                }
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            else
            {
                xRotate = Mathf.Clamp(xRotate - adRotate * Time.deltaTime, -30, 30);
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            */
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            /*
            if (System.Math.Abs(xRotate) + System.Math.Abs(zRotate) >= 30)
            {
                zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, -30, 30);
                if (xRotate >= 0)
                {
                    xRotate = Mathf.Clamp(xRotate - adRotate * Time.deltaTime, -30, 30);
                }
                else
                {
                    xRotate = Mathf.Clamp(xRotate + adRotate * Time.deltaTime, -30, 30);
                }
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            else
            {
                zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, -30, 30);
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            */
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            /*
            if (System.Math.Abs(xRotate) + System.Math.Abs(zRotate) >= 30)
            {
                zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -30, 30);
                if (xRotate >= 0)
                {
                    xRotate = Mathf.Clamp(xRotate - adRotate * Time.deltaTime, -30, 30);
                }
                else
                {
                    xRotate = Mathf.Clamp(xRotate + adRotate * Time.deltaTime, -30, 30);
                }
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            else
            {
                zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -30, 30);
                transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
            }
            */
        }


    }
}
