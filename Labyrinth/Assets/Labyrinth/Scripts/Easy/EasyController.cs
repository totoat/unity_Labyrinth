using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyController : MonoBehaviour {

    public float adRotate = 100;
    private float zRotate = 0;
    private float xRotate = 0;
    private Vector3 tempPos;

    private void Start()
    {   
        tempPos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update () {

        MouseInput();

        KeyInput();
    }

    // マウス操作(おすすめ)
    private void MouseInput()
    {   
        //右
        if (Input.mousePosition.x - tempPos.x > 0)
        {
            zRotate = Mathf.Clamp(zRotate - adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
        }
        //左
        else if (Input.mousePosition.x - tempPos.x < 0)
        {
            zRotate = Mathf.Clamp(zRotate + adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
        }
        //上
        if (Input.mousePosition.y - tempPos.y > 0)
        {
            xRotate = Mathf.Clamp(xRotate + adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
        }
        //下
        else if (Input.mousePosition.y - tempPos.y < 0)
        {
            xRotate = Mathf.Clamp(xRotate - adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
        }
        tempPos = Input.mousePosition;
    }
    // キーボード操作
    private void KeyInput()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            xRotate = Mathf.Clamp(xRotate + adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);

        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            xRotate = Mathf.Clamp(xRotate - adRotate * Time.deltaTime, -30, 30);
            transform.eulerAngles = new Vector3(xRotate, 0, zRotate);
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
