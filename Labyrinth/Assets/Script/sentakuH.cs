using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sentakuH : MonoBehaviour {

    public MeshRenderer meshRenderer;
    public Color Default;

    // Use this for initialization
    void Start () {
        meshRenderer = GetComponent<MeshRenderer>();
        Default = meshRenderer.material.color;
        // 透明に変えておく
        meshRenderer.material.color = new Color(256, 256, 256, 0);
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            meshRenderer.material.color = new Color(256, 256, 256, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            meshRenderer.material.color = Default;
        }

        if (Input.GetKeyUp(KeyCode.Return) && meshRenderer.material.color==Default)
        {
            SceneManager.LoadScene("Easy");
        }
    }
}
